﻿using System;
using System.Linq;

namespace Orleankka.Core
{
    static class MessageEnvelope
    {
        public static IMessageSerializer Serializer;

        public static void Reset()
        {
            Serializer = new DefaultMessageSerializer();
        }

        static MessageEnvelope()
        {
            Reset();
        }
    }
}