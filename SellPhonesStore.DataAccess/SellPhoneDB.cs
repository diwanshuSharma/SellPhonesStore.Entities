using SellPhonesStore.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace SellPhonesStore.DataAccess
{
    public class SellPhoneDB : DbContext
    {
        public DbSet<Phone> phones { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrdereredPhone> OrdereredPhones { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }

    }

   
}