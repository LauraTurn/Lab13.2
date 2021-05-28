using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeHouse.Models
{
    public class Customer
    {
        public string first { get; set; }
        public string last { get; set; }
        public string surname { get; set; }
        public string emailaddress { get; set; }
        public string pass { get; set; }
        public string confirmpass { get; set; }
        public int custage { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }

        public static List<Customer> AllInfo = new List<Customer>();
    }
}
