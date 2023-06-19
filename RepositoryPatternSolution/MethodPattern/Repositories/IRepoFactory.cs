using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.Repositories
{
    public interface IRepoFactory
    {
        IGenericRepo<T> Get<T>() where T : class;
    }

}
