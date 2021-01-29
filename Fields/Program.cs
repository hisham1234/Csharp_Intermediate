using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields


{

    public class Order
    {

    }

    public class Customer
    {
        public  readonly List<Order> Orders = new List<Order>();
        public int MyProperty { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
        public void Promote()
        {
           // Orders = new List<Order>(); //--Compilation error
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cus = new Customer();
            cus.Orders.Add(new Order());
        }
    }
}
