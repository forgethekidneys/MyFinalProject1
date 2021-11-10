using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{   //Context : Db tabloları ile proje classlarını bağlamak                   //override ile projemizin hangi veritabanı ile ilişkili olduğunu belli ederiz
    public class NorthwindContext:DbContext                                   //base gelen DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)                  //OnConfiguring = projem hangi veri tabanı ile ilişkili
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;DATABASE=Northwind;Trusted_Connection=true");                //Connection string  
        }

          
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Order> Orders { get; set; }
    }
}
