using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Repositories;

namespace ViewComponentsCountires.ViewComponents
{
    public class CustomerViewComponent
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerViewComponent(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string Invoke()
        {
            return $"{_customerRepository.Customers().Count()} Customers";
        }
    }
}
