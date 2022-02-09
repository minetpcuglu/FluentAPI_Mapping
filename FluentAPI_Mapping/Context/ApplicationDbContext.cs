using FluentAPI_Mapping.Entities;
using FluentAPI_Mapping.Entities.Concrete;
using FluentAPI_Mapping.Entities.EfCodeFirstMappings.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI_Mapping.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } // =>  "DB bağlantısını concructor method ile oluşturuldu."
        public  DbSet<Employee> Employees { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<Product> Products { get; set; }

        

        // Şimdi yaptığımız Map'leme işlemini override edeceğiz.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeMap());
            builder.ApplyConfiguration(new OrderMap());
            builder.ApplyConfiguration(new ProductMap());
         
            base.OnModelCreating(builder);
        }
    }
}
