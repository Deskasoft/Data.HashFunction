﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.HashFunction.MetroHash
{
    public interface IMetroHash
        : IHashFunctionAsync
    {
        IMetroHashConfig Config { get; }
    }
}
