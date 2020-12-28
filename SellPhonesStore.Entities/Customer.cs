using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Customer
    {
        public long CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailID { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string PinCode { get; set; }
        public long Mobile { get; set; }
        public List<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();

    }
}
