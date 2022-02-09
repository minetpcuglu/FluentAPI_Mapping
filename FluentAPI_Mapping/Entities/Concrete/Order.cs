using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Entities.Concrete
{
    public class Order : BaseEntity<int>
    {
        //public Order()
        //{
        //    Products = new List<Product>();  //nullreferance hatası almamak için
        //}
        public string OrderDate { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
