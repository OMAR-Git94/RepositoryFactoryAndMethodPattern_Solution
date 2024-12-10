using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Factories
{
    public class RepositoryFactoryImpl : IRepositoryFactory
    {
        public IGenecricRepostory<T> GetRepo<T>() where T : EntityBase, new()
        {
            return new GenericRepositoryImpl<T>();
        }
    }
}
