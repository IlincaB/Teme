using CarDealership.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCarDealership;

namespace xUnitTestProject
{   
    internal class Repository : IRepository
    {
        private List<Order> orders;

        public Repository()
        {
            orders=new List<Order>();
        }
        public void Add(Order order)
        {
            orders.Add(order);  
        }

        public void Delete(Order order)
        {
            orders.Remove(order);
        }

        public void Update(Order order)
        {
            var _order = orders.First(o => o.Id == order.Id);
            _order=order;
        }
    }
}
