using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Models;

namespace ViewComponentsCountires.Repositories
{
        public interface ICustomerRepository
        {
            IEnumerable<Customer> Customers();
            void AddCustomers(Customer customer);
        }

    }

