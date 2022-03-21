using TemaCurs2.entities;

namespace TemaCurs2.services
{
    public class CarService
    {
        private List<Car> cars;

        public CarService() //constructor
        {
            this.cars = new List<Car>();
        }

        public bool Add(string name)
        {
            var id = cars.Count + 1;
            cars.Add(new Car()
            {
                Id = id,
                Name = name,
                IsAvailable = true,
                CustomerId = 0
            });   //am creat si adaugat o noua masina
            return true;
        }

        public bool Remove(int id)
        {
            Car car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
                return false;
            cars.Remove(car);
            return true;
        }

        public bool UpdateName(int id, string name) 
        {
            Car car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
                return false;
            car.Name= name;
            return true;
        }

        public List<Car> ListAllAvailableCars()

        {
            var availableCars = cars.FindAll(c => c.IsAvailable == true);
            return availableCars;
        }

        public bool BuyCar(int id, int customerId)
        {
            var car = cars.Find(c => c.Id == id);
            if (car == null || car.IsAvailable==false)
                return false;
            car.CustomerId = customerId;
            car.IsAvailable = false;
            return true;
        }

    }

}
