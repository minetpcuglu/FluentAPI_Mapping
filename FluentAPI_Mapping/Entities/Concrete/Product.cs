using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.Concrete
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public string UnitInStock { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
