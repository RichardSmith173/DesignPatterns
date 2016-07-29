using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    interface IRepository<T> where T : EntityBase
    {
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
