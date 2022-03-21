using TemaCurs2.entities;

namespace TemaCurs2.services
{
    public class CustomerService
    {
        private List<Customer> customers;

        public CustomerService() //constructor
        {
            this.customers = new List<Customer>();
        }

        public bool Add(string name)
        {
            var id = customers.Count + 1;
            customers.Add(new Customer()
            {
                Id = id,
                Name = name,
            });   //am creat si adaugat o noua masina
            return true;
        }

        public bool Remove(int id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return false;
            customers.Remove(customer);
            return true;
        }
    }
}
