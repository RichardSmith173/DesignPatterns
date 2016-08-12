using PolicyHost.Entity;
using PolicyHost.Enumerations;
using System;
using System.Collections.Generic;

namespace PolicyTest.Seed
{
    internal abstract class DataGenerator<T>
    {
        protected delegate IEnumerable<T> CreateEntity();
    }
}