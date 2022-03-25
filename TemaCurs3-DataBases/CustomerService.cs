using CarDealership.Data.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace WebCarDealership.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly DealershipDbContext _dbContext;

        public CustomerController(DealershipDbContext dbContext)
        {   
            _dbContext=dbContext;
        }

        [HttpPost] //post-apartine de adaugare

        public async Task<IActionResult> Add([FromBody]int id, string email, string name)
        {
            var dbModel = new Customer
            {
                Id=id,
                Email=email,
                Name=name,  
                Orders = new List<Order>()

            };
            _dbContext.Customers.Add(dbModel); //am adaugat in baza de date
            await _dbContext.SaveChangesAsync(); //am salvat
            return Created(Request.GetDisplayUrl(), dbModel);
            
        }


    }
}
