﻿using System;
using System.Collections.Generic;
using System.Data.HashFunction.Core;
using System.Data.HashFunction.Core.Utilities;
using System.Data.HashFunction.Core.Utilities.UnifiedData;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.HashFunction.MurmurHash
{
    /// <summary>
    /// Implementation of MurmurHash1 as specified at https://github.com/aappleby/smhasher/blob/master/src/MurmurHash1.cpp 
    ///   and https://github.com/aappleby/smhasher/wiki/MurmurHash1.
    /// 
    /// This hash function has been superseded by <seealso cref="IMurmurHash2">MurmurHash2</seealso> and <seealso cref="IMurmurHash3">MurmurHash3</seealso>.
    /// </summary>
    internal class MurmurHash1_Implementation
        : HashFunctionAsyncBase,
            IMurmurHash1
    {

        /// <summary>
        /// Configuration used when creating this instance.
        /// </summary>
        /// <value>
        /// A clone of configuration that was used when creating this instance.
        /// </value>
        public IMurmurHash1Config Config => _config.Clone();

        public override int HashSizeInBits { get; } = 32;


        /// <summary>
        /// Constant m as defined by MurmurHash1 specification.
        /// </summary>
        private const UInt32 m = 0XC6A4A793;


        private readonly IMurmurHash1Config _config;


        /// <summary>
        /// Initializes a new instance of the <see cref="MurmurHash1_Implementation"/> class.
        /// </summary>
        /// <param name="config">The configuration to use for this instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="config"/></exception>
        public MurmurHash1_Implementation(IMurmurHash1Config config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            _config = config.Clone();
        }


        /// <inheritdoc />
        protected override byte[] ComputeHashInternal(IUnifiedData data, CancellationToken cancellationToken)
        {
            UInt32 h = _config.Seed ^ ((UInt32) data.Length * m);

            data.ForEachGroup(4, 
                (dataGroup, position, length) => {
                    ProcessGroup(ref h, dataGroup, position, length);
                },
                (remainder, position, length) => {
                    ProcessRemainder(ref h, remainder, position, length);
                },
                cancellationToken);
 
            h *= m;
            h ^= h >> 10;
            h *= m;
            h ^= h >> 17;

            return BitConverter.GetBytes(h);
        }
        
        /// <inheritdoc />
        protected override async Task<byte[]> ComputeHashAsyncInternal(IUnifiedDataAsync data, CancellationToken cancellationToken)
        {
            UInt32 h = _config.Seed ^ ((UInt32) data.Length * m);

            await data.ForEachGroupAsync(4,
                    (dataGroup, position, length) => {
                        ProcessGroup(ref h, dataGroup, position, length);
                    },
                    (remainder, position, length) => {
                        ProcessRemainder(ref h, remainder, position, length);
                    },
                    cancellationToken)
                .ConfigureAwait(false);

            h *= m;
            h ^= h >> 10;
            h *= m;
            h ^= h >> 17;

            return BitConverter.GetBytes(h);
        }


        private static void ProcessGroup(ref UInt32 h, byte[] dataGroup, int position, int length)
        {
            for (var x = position; x < position + length; x += 4)
            {
                h += BitConverter.ToUInt32(dataGroup, x);
                h *= m;
                h ^= h >> 16;
            }
        }

        private static void ProcessRemainder(ref UInt32 h, byte[] remainder, int position, int length)
        {
            Debug.Assert(length > 0);
            Debug.Assert(length < 4);

            switch (length)
            {
                case 3: h += (UInt32) remainder[position + 2] << 16; goto case 2;
                case 2: h += (UInt32) remainder[position + 1] <<  8; goto case 1;
                case 1:
                    h += (UInt32) remainder[position];
                    break;
            };

            h *= m;
            h ^= h >> 16;
        }
    }
}
