using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Repsitories
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        void Update(T entity);
        void Add(T entity);
        void Delete(int id);
        T Get(int id);
        IList<T> GetAll();
    }

}
