using System.Diagnostics.Metrics;
using WinterBootcamp.Entities;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Repository
{
    public class EmployerRepository : IEmployerRepository
    {
        private List<Employer> Employers { get; set; } = null!;
        private List<Country> Countries { get; set; } = null!;
        private List<State> States { get; set; } = null!;
        private List<City> Cities { get; set; } = null!;


        public EmployerRepository() 
        {
            Employers = new List<Employer>();
            Countries = new List<Country>();
            States = new List<State>();
            Cities = new List<City>();
        }

        public async Task<bool> Register(Employer employer)
        {
            if (employer == null)
            {
                return false;
            }

            if (Employers.Any(e => e.Username == employer.Username))
            {
                return false;
            }

            employer.EmployerId = Guid.NewGuid();
            Employers.Add(employer);

            return true;
        }

        public async Task<Employer?> Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            var existingEmployer = Employers.FirstOrDefault(e => e.Username == username && e.Password == password);

            return existingEmployer;
        }

        public async Task<bool> AddCountry(Country country)
        {
            if(country == null)
            {
                return false;
            }

            if(Countries.Any(c=>c.CountryName == country.CountryName))
            {
                return false;
            }

            country.CountryId = Guid.NewGuid();
            Countries.Add(country);

            return true;

        }

        public async Task<Country> GetCountry(Guid countryId)
        {
            return Countries.FirstOrDefault(c => c.CountryId == countryId);
        }

        public async Task<List<Country>> GetCountries()
        {
            return Countries;
        }

        public async Task<bool> AddState(State state)
        {
            if (state == null)
            {
                return false;
            }

            if (States.Any(c => c.StateName == state.StateName))
            {
                return false;
            }

            state.StateId = Guid.NewGuid();
            States.Add(state);

            return true;
        }

        public async Task<State> GetState(Guid stateId)
        {
            return States.FirstOrDefault(s => s.StateId == stateId);
        }

        public async Task<List<State>> GetStates()
        {
            return States;
        }

        public async Task<bool> AddCity(City city)
        {
            if (city == null)
            {
                return false;
            }

            if (Cities.Any(c => c.CityName == city.CityName))
            {
                return false;
            }

            city.CityId = Guid.NewGuid();
            Cities.Add(city);

            return true;
        }

        public async Task<City> GetCity(Guid cityId)
        {
            return Cities.FirstOrDefault(city => city.CityId == cityId);
        }

        public async Task<List<City>> GetCities()
        {
            return Cities;
        }
        
        public async Task<List<City>> GetCityByCountryId(Guid countryId)
        {
            return Cities.FindAll(city => city.CountryId == countryId);
        }
    }
}