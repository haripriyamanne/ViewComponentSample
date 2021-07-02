using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Models;

namespace ViewComponentsCountires.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer
            {
                Name = "Hari",
                Age = 23
            },
            new Customer
            {
                Name = "Jannu",
                Age = 28
            }
        };

        public IEnumerable<Customer> Customers()
        {
            return _customers;
        }

        public void AddCustomers(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
