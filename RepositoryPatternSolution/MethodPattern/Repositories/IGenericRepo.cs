using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        IList<T> Get();
        T Get(Func<T, bool> predicate);
        void Add(T item);
        void Update(Func<T, bool> predicate, T item);
        void Delete(Func<T, bool> predicate);
    }

}
