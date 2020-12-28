using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        public List<CustomerOrder> GetAllCustomerOrders()
        {
            var db = new SellPhoneDB();

            return (from p in db.CustomerOrders.Include("Customer")
                    select p).ToList();
        }

        public List<CustomerOrder> GetCustomerOrders(long customerID)
        {
            var db = new SellPhoneDB();

            return (from p in db.CustomerOrders.Include("Customer")
            where p.Customer.CustomerID == customerID
            select p).ToList();
            
        }

        public long SaveCustomer(Customer customer)
        {
            var db = new SellPhoneDB();

            db.Customers.Add(customer);
            return db.SaveChanges();
        }

        public long SaveOrder(CustomerOrder order)
        {
            var db = new SellPhoneDB();

            db.CustomerOrders.Add(order);
            return db.SaveChanges();

        }

        public long SaveOrderedPhone(OrdereredPhone orderPhone, long orderId)
        {
            var db = new SellPhoneDB();

            CustomerOrder order = db.CustomerOrders.Find(orderId);
            order.OrdereredPhones.Add(orderPhone);
            return db.SaveChanges();

        }

        public long SavePhone(Phone phone)
        {
            var db = new SellPhoneDB();

            db.phones.Add(phone);
            return db.SaveChanges();

        }
    }
}
