﻿using System;
using System.Linq;

namespace Orleankka
{
    public abstract class ObserverRef
    {
        public abstract void Notify(object message);
    }
}