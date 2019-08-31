﻿using System;
using System.Collections.Generic;
using System.Data.HashFunction.Jenkins;
using System.Data.HashFunction.Test._Utilities;
using System.Text;

namespace System.Data.HashFunction.Test.Jenkins
{
    public class JenkinsOneAtATime_Implementation_Tests
    {

        public class IHashFunctionAsync_Tests
            : IHashFunctionAsync_TestBase<IJenkinsOneAtATime>
        {
            protected override IEnumerable<KnownValue> KnownValues { get; } =
                new KnownValue[] {
                    new KnownValue(32, TestConstants.FooBar, 0xf952fde7),
                };

            protected override IJenkinsOneAtATime CreateHashFunction(int hashSize) =>
                new JenkinsOneAtATime_Implementation();
        }


    }
}
