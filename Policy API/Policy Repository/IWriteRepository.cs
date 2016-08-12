using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyRepository
{
    interface IWriteRepository<T>
    {
        void Add(T entity);
    }
}
