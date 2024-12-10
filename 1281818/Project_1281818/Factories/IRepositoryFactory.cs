using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Factories
{
    public interface IRepositoryFactory
    {
        IGenecricRepostory<T> GetRepo<T>() where T : EntityBase, new();
    }
}
