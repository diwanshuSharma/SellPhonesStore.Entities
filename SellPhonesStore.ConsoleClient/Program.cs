using SellPhonesStore.DataAccess;
using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding Phone
            AddingPhone();

            // Adding Customer
            AddingCustomer();

            //SaveOrder
            SaveOrder();

            //Save Ordered Phone
            SaveOrderedPhone();

            //Get Customers Order
            GetCustomerOrder();

            // Get All Customers Orders
            GetAllCustomersorders();

        }

        private static void GetAllCustomersorders()
        {
            PhoneRepository phoneRepository = new PhoneRepository();
            List<CustomerOrder> customerOrders = phoneRepository.GetAllCustomerOrders();

            foreach (var cOrder in customerOrders)
            {
                Console.WriteLine($" {cOrder.CustomerOrderID}  {cOrder.Customer.CustomerName} {cOrder.OrderTotal}");
            }
        }

        private static void GetCustomerOrder()
        {
            PhoneRepository phoneRepository = new PhoneRepository();
            List<CustomerOrder> customerOrders = phoneRepository.GetCustomerOrders(2);

            foreach (var cOrder in customerOrders)
            {
                Console.WriteLine($" {cOrder.CustomerOrderID}  {cOrder.Customer.CustomerName} {cOrder.OrderTotal}");
            }
        }

        private static void SaveOrderedPhone()
        {
            PhoneRepository phoneRepository = new PhoneRepository();
            OrdereredPhone ordereredPhone = new OrdereredPhone
            {
                OrderedPhone = new Phone
                {
                    PhoneDescrption = "Very Very Good Phone",
                    Price = 11,
                    ManufactureDate = DateTime.Today,
                    BrandName = "Brandsssssss",
                    InStock = 100
                },
                Quantity = 100
            };
            phoneRepository.SaveOrderedPhone(ordereredPhone, 1);
        }

        private static void SaveOrder()
        {
            PhoneRepository phoneRepository = new PhoneRepository();
            OrdereredPhone ordereredPhone = new OrdereredPhone
            {
                OrderedPhone = new Phone
                {
                    PhoneDescrption = "Very Good Phone",
                    Price = 10,
                    ManufactureDate = DateTime.Today,
                    BrandName = "My Brand",
                    InStock = 10000
                },
                Quantity = 100
            };
            CustomerOrder order = new CustomerOrder
            {
                Orderdate = DateTime.Now,
                Customer = new Customer
                {
                    CustomerName = "manish",
                    EmailID = "manish@123gamil.com",
                    City = "bangalore",
                    StreetName = "street 1",
                    PinCode = "12345",
                    Mobile = 1234567890
                }
            };
            order.OrdereredPhones.Add(ordereredPhone);

            phoneRepository.SaveOrder(order);
        }

        private static void AddingCustomer()
        {
            PhoneRepository phoneRepository = new PhoneRepository();
            Customer customer = new Customer
            {
                CustomerName = "Diwanshu",
                EmailID = "diw@123gamil.com",
                City = "bangalore",
                StreetName = "street 1",
                PinCode = "12345",
                Mobile = 1234567890
            };

            phoneRepository.SaveCustomer(customer);
        }

        private static void AddingPhone()
        {
            PhoneRepository phoneRepository = new PhoneRepository();

            Phone phone = new Phone
            {
                PhoneDescrption = "Very Good Phone",
                Price = 10,
                ManufactureDate = DateTime.Today,
                BrandName = "My Brand",
                InStock = 10000
            };

            phoneRepository.SavePhone(phone);
        }
    }
}
