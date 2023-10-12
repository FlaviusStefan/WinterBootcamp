using WinterBootcamp.Entities;

namespace WinterBootcamp.Repository.Interfaces
{
    public interface IEmployerRepository
    {
        Task<bool> Register(Employer employer);
        Task<Employer> Login(string username, string password);

        Task<bool> AddCountry(Country country);
        Task<Country> GetCountry(Guid countryId);
        Task<List<Country>> GetCountries();

        Task<bool> AddState(State state);
        Task<State> GetState(Guid stateId);
        Task<List<State>> GetStates();

        Task<bool> AddCity(City city);
        Task<City> GetCity(Guid cityId);
        Task<List<City>> GetCities();
        Task<List<City>> GetCityByCountryId(Guid countryId);

    }
}