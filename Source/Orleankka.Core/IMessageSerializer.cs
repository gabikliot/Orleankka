﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Orleankka.Core
{
    public interface IMessageSerializer
    {
        void Init(IDictionary<string, string> properties);

        /// <summary>
        /// Serializes message to byte[]
        /// </summary>
        byte[] Serialize(object message);

        /// <summary>
        /// Deserializes byte[] back to message
        /// </summary>
        object Deserialize(byte[] bytes);
    }

    class DefaultMessageSerializer : IMessageSerializer
    {
        public void Init(IDictionary<string, string> properties)
        {}

        public byte[] Serialize(object message)
        {
            using (var stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, message);
                return stream.ToArray();
            }
        }

        public object Deserialize(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                var formatter = new BinaryFormatter();
                return formatter.Deserialize(stream);
            }
        }
    }
}
