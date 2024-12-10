using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Repositories
{
    public interface IGenecricRepostory<T> where T : EntityBase, new()
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Insert(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
