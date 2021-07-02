using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Repositories;

namespace ViewComponentsCountires.ViewComponents
{
    public class CountryViewComponent
    {
        private readonly ICountryRepository _countryRepository;
        public CountryViewComponent(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public string Invoke()
        {
            return $"{_countryRepository.Countries().Count()} Countries with a " +
                   $"Population of {_countryRepository.Countries().Sum(x => x.Population)}";
        }
    }
}
