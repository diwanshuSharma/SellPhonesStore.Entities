using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Phone
    {
        public long PhoneID { get; set; }
        public string PhoneDescrption { get; set; }
        public float Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string BrandName { get; set; }
        public int InStock { get; set; }
    }
}
