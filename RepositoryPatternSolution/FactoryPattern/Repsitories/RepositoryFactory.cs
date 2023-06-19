using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Repsitories
{
    public class RepositoryFactory
    {
        public T CreateRepository<T>() where T : class
        {
            
            return Activator.CreateInstance(typeof(T)) as T;
        }
    }
}
