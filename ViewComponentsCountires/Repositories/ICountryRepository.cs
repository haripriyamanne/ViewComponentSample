using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsCountires.Models;

namespace ViewComponentsCountires.Repositories
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries();

        void AddCountry(Country country);
    }
}
