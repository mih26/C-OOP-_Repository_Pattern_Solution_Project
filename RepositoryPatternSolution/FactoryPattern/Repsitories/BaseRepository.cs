using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Repsitories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class, IEntity, new()
    {
        IList<T> list;
        public GenericRepository()
        {
            this.list = new List<T>();
        }
        // Implementation of IRepository
        public void Update(T entity)
        {
            var item =this.list.FirstOrDefault(t => t.Id == entity.Id);
            if (item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);
                list.Insert(i, entity);
            }
        }
        public void Delete(int id)
        {
            var item = this.list.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);
                
            }
        }
        public T Get(int id)
        {
            return this.list.FirstOrDefault(t => t.Id == id); 
        }
        public IList<T> GetAll()
        {
            return this.list;
        }
        public void Add(T entity)
        {
            this.list.Add(entity);
        }
    }
    
}
