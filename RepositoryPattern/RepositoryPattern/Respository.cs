using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RepositoryPattern
{
    public class Respository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _dbContext;

        public Respository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
