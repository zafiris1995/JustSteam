using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core
{
    public interface IGenericRepository <T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T obj);
        void Edit(T obj);
        void Delete(object id);
        void Save();
    }
}
