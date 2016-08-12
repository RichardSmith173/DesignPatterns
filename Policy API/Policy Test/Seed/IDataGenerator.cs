using System.Collections.Generic;

namespace PolicyTest.Seed
{
    internal interface IDataGenerator<T>
    {
        IEnumerable<T> SeedEntity();
    }
}