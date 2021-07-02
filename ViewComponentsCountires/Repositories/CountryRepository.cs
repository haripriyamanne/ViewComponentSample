using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Models;

namespace ViewComponentsCountires.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly List<Country> _countries = new List<Country>
        {
            new Country
            {
                Name = "Switzerland",
                Population = 8000
            },
            new Country
            {
                Name = "India",
                Population = 10000
            }
        };

        public IEnumerable<Country> Countries()
        {
            return _countries;
        }

        public void AddCountry(Country country)
        {
            _countries.Add(country);
        }
    }
}
