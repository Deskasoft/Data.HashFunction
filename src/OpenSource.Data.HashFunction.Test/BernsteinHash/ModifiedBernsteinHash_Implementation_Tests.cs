﻿using System;
using System.Collections.Generic;
using OpenSource.Data.HashFunction.BernsteinHash;
using OpenSource.Data.HashFunction.Test._Utilities;
using System.Text;
using Xunit;

namespace OpenSource.Data.HashFunction.Test.BernsteinHash
{
    public class ModifiedBernsteinHash_Implementation_Tests
    {

        [Fact]
        public void ModifiedBernsteinHash_Implementation_HashSizeInBits_IsSet()
        {
            var bernsteinHash = new BernsteinHash_Implementation();

            Assert.Equal(32, bernsteinHash.HashSizeInBits);
        }


        public class IStreamableHashFunction_Tests
            : IStreamableHashFunction_TestBase<IModifiedBernsteinHash>
        {
            protected override IEnumerable<KnownValue> KnownValues { get; } =
                new KnownValue[] {
                    new KnownValue(32, TestConstants.Empty, 0x00000000),
                    new KnownValue(32, TestConstants.FooBar, 0xf030b397),
                    new KnownValue(32, TestConstants.LoremIpsum, 0xfeceaf2a),
                };

            protected override IModifiedBernsteinHash CreateHashFunction(int hashSize)
            {
                return new ModifiedBernsteinHash_Implementation();
            }
        }
    }
}
