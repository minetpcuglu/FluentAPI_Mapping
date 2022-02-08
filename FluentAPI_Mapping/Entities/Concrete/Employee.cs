using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.Concrete
{
    public class Employee :BaseEntity<int>
    {
        public Employee()
        {
            Orders = new List<Order>();  //nullreferance hatası almamak için
        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
       
    }
}
