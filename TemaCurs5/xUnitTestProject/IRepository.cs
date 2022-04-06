using CarDealership.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestProject
{
    internal interface IRepository
    {
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(Order order);
    }
}
