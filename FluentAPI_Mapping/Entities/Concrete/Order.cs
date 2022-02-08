using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.Concrete
{
    public class Order : BaseEntity<int>
    {
        public Order()
        {
            Products = new List<Product>();  //nullreferance hatası almamak için
        }
        public int OrderID { get; set; }
        public string OrderDate { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public List<Product> Products { get; set; }
    }
}
