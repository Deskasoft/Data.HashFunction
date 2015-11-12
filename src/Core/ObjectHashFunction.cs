﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

namespace System.Data.HashFunction
{

    /// <summary>
    /// Turns any <see cref="IHashFunction"/> into an <see cref="IObjectHashFunction"/>.
    /// </summary>
    public class ObjectHashFunction
        : IObjectHashFunction
    {

        /// <summary>
        /// Size of produced hash, in bits.
        /// </summary>
        /// <value>
        /// The size of the hash, in bits.
        /// </value>
        public int HashSize { get { return _hashFunction.HashSize; } }

        
        /// <summary>
        /// Set of built in formatters to choose from.
        /// </summary>
        public enum BuiltInSerializerOptions
        {
            /// <summary>
            /// Use <see cref="BinaryFormatter"/> for serialization.
            /// </summary>
            BinaryFormatter,

            /// <summary>
            /// Use <see cref="BitConverter"/> for serialization via the GetBytes methods.
            /// </summary>
            /// <remarks>
            /// Only works for existing overloads of BitConverter.GetBytes.
            /// </remarks>
            BitConverter,
        }
        

        private readonly IHashFunction _hashFunction;
        private readonly Func<object, byte[]> _objectSerializer;

#if !NET40
        private static IReadOnlyDictionary<Type, MethodInfo> BitConverterMethods { get { return _BitConverterMethods.Value; } }
        private static readonly Lazy<IReadOnlyDictionary<Type, MethodInfo>> _BitConverterMethods = new Lazy<IReadOnlyDictionary<Type, MethodInfo>>(GetBitConverterMethods);
#else
        private static IDictionary<Type, MethodInfo> BitConverterMethods { get { return _BitConverterMethods.Value; } }
        private static readonly Lazy<IDictionary<Type, MethodInfo>> _BitConverterMethods = new Lazy<IDictionary<Type, MethodInfo>>(GetBitConverterMethods);
#endif


        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectHashFunction" /> class using one of the built in serialization options.
        /// </summary>
        /// <param name="hashFunction">The hash function to use to calculate the hash.</param>
        /// <param name="builtInSerializerOption">The built in serializer option to serailize the object with.</param>
        public ObjectHashFunction(IHashFunction hashFunction, BuiltInSerializerOptions builtInSerializerOption)
        {
            if (hashFunction == null)
                throw new ArgumentNullException("hashFunction");


            _hashFunction = hashFunction;

            switch (builtInSerializerOption)
            {
                case BuiltInSerializerOptions.BinaryFormatter:
                    _objectSerializer = BinaryFormatterSerializer;
                    break;

                case BuiltInSerializerOptions.BitConverter:
                    _objectSerializer = BitConverterSerializer;
                    break;

                default:
                    throw new ArgumentOutOfRangeException("builtInSerializerOption", builtInSerializerOption, "builtInSerializerOption must be a valid BuiltInSerializerOptions value.");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectHashFunction"/> class using a custom serializer.
        /// </summary>
        /// <param name="hashFunction">The hash function to use to calculate the hash.</param>
        /// <param name="customSerializer">The serializer to serailize the object with.</param>
        public ObjectHashFunction(IHashFunction hashFunction, Func<object, byte[]> customSerializer)
        {
            if (hashFunction == null)
                throw new ArgumentNullException("hashFunction");

            if (customSerializer == null)
                throw new ArgumentNullException("customSerializer");


            _hashFunction = hashFunction;
            _objectSerializer = customSerializer;
        }


        /// <summary>
        /// Computes hash value for given object.
        /// </summary>
        /// <param name="data">Object to hash.</param>
        /// <returns>
        /// Hash value of the data as byte array.
        /// </returns>
        public byte[] CalculateHash(object data)
        {
            if (data == null)
                throw new ArgumentNullException("data");


            return _hashFunction.ComputeHash(
                _objectSerializer(data));
        }



        private static byte[] BinaryFormatterSerializer(object data)
        {
            using (var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, data);

                return memoryStream.ToArray();
            }
        }

        private static byte[] BitConverterSerializer(object data)
        {
            var objectType = data.GetType();

            if (objectType == typeof(byte))
                return new byte[] { (byte) data };


            if (!BitConverterMethods.ContainsKey(objectType))
            {
                throw new InvalidOperationException(
                    string.Format("BuiltInSerializationOptions.BitConverter cannot handle type \"{0}\"", objectType.Name));
            }

            var getBytesMethod = BitConverterMethods[objectType];

            return (byte[]) getBytesMethod.Invoke(null, new[] { data });
        }

#if !NET40
        private static IReadOnlyDictionary<Type, MethodInfo> GetBitConverterMethods()
#else
        private static IDictionary<Type, MethodInfo> GetBitConverterMethods()
#endif
        {
            var type = typeof(BitConverter);
            var methodInfos = type.GetMethods(Reflection.BindingFlags.Public | Reflection.BindingFlags.Static | Reflection.BindingFlags.InvokeMethod);


            var methods = new Dictionary<Type, MethodInfo>();

            foreach (var methodInfo in methodInfos)
            {
                if (methodInfo.Name != "GetBytes")
                    continue;


                methods.Add(
                    methodInfo.GetParameters().Single().ParameterType,
                    methodInfo);
            }
            
            return methods;
        }
    }
}
