using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.Repositories
{
    
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        IList<T> list;
        public GenericRepo()
        {
            this.list = new List<T>();
        }
        public GenericRepo(IList<T> list)
        {
            this.list = list;
        }
        public IList<T> Get()
        {
            return this.list;
        }
        
        public T Get(Func<T, bool> predicate)
        {
            var item = this.list.Where(predicate).FirstOrDefault();
            return item;
        }
        public void Update(Func<T, bool> predicate, T item)
        {

            var x = this.list.Where(predicate).FirstOrDefault();

            if (x != null)
            {
                var i = this.list.IndexOf(x);
                this.list.RemoveAt(i);
                this.list.Insert(i, item);

            }
        }
        public void Add(T item)
        {
            this.list.Add(item);
        }
        public void Delete(Func<T, bool> predicate) 
        {
            var item = this.list.FirstOrDefault(predicate);
            if(item != null)
            {
                var i = this.list.IndexOf(item);
                this.list.RemoveAt(i);
            }
        }

    }
}
