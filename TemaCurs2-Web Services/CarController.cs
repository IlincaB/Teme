using Microsoft.AspNetCore.Mvc;
using TemaCurs2.services;

namespace TemaCurs2
{   [Route("api/[controller]")] //ruta ptr controller 
    [ApiController]
    public class CarController : Controller
    {
        public CarService carService;
        public CustomerService customerService;
        public CarController()
        {
            carService = new CarService();
            customerService = new CustomerService();
        }
        [HttpGet(nameof(AddCar))]
        public IActionResult AddCar(string name)
        {
            var result = carService.Add(name);
            if(result)
                return Ok(result);
            return BadRequest();
        }
    }
}
