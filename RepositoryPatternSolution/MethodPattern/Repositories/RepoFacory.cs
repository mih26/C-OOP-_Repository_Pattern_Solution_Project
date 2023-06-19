using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.Repositories
{
    public class RepoFactory : IRepoFactory
    {
        public IGenericRepo<T> Get<T>() where T : class
        {
            return new GenericRepo<T>(new List<T>());
        }
        public GenericRepo<T> Create<T>() where T: class
        {
            return Activator.CreateInstance<GenericRepo<T>>();
        }
    }

}
