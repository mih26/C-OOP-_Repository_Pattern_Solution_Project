using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    public class Trainee : IEntity
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Round { get; set; }
    }
}
