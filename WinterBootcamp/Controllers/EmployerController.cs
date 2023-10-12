using Microsoft.AspNetCore.Mvc;
using WinterBootcamp.Entities;
using WinterBootcamp.Repository.Interfaces;
using WinterBootcamp.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace WinterBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerRepository _employerRepository;

        public EmployerController(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository ?? throw new ArgumentNullException(nameof(employerRepository));
        }



        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(Employer employer)
        {
            
            if(await _employerRepository.Register(employer))
            {
                return Ok("Registration succesful");
            }

            return BadRequest("Invalid username or password");

        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var employer = await _employerRepository.Login(username, password);

            if (employer != null)
            {
                return Ok("Login succesful");
            }

            return BadRequest("Invalid username or password");
        }

        [HttpPost]
        [Route("add-country")]
        public async Task<IActionResult> AddCountry([FromBody] CountryDto countryDto)
        {
            Country country = new Country();
            
            country.CountryName = countryDto.CountryName;

            var isSuccessful = await _employerRepository.AddCountry(country);
            if (isSuccessful)
            {
                return Ok("Country added successfully");
            }
            return BadRequest("Failed to add country");
        }

        [HttpGet]
        [Route("get-country/{countryId}")]
        public async Task<IActionResult> GetCountry(Guid countryId)
        {
            var country = await _employerRepository.GetCountry(countryId);

            if (country != null)
            {
                return Ok(country);
            }

            return NotFound("Country not found");
        }

        [HttpGet]
        [Route("get-countries")]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await _employerRepository.GetCountries();

            if (countries != null)
            {
                return Ok(countries);
            }

            return NotFound("No countries found");
        }

        [HttpPost]
        [Route("add-state")]
        public async Task<IActionResult> AddState([FromBody] StateDto stateDto)
        {
            State state = new State();
            state.CountryId = stateDto.CountryId;
            state.StateName = stateDto.StateName;

            var isSuccessful = await _employerRepository.AddState(state);
            if (isSuccessful)
            {
                return Ok("State added successfully");
            }
            return BadRequest("Failed to add state");
        }

        [HttpGet]
        [Route("get-state/{stateId}")]
        public async Task<IActionResult> GetState(Guid stateId)
        {
            var state = await _employerRepository.GetState(stateId);

            if (state != null)
            {
                return Ok(state);
            }

            return NotFound("State not found");
        }

        [HttpGet]
        [Route("get-states")]
        public async Task<IActionResult> GetStates()
        {
            var states = await _employerRepository.GetStates();

            if (states != null)
            {
                return Ok(states);
            }

            return NotFound("No states found");
        }

        [HttpPost]
        [Route("add-city")]
        public async Task<IActionResult> AddCity([FromBody] CityDto cityDto)
        {
            City city = new City();
            city.CountryId = cityDto.CountryId;
            city.StateId = cityDto.StateId;
            city.CityName = cityDto.CityName;

            var isSuccessful = await _employerRepository.AddCity(city);
            if (isSuccessful)
            {
                return Ok("City added successfully");
            }
            return BadRequest("Failed to add city");
        }

        [HttpGet]
        [Route("get-city/{cityId}")]
        public async Task<IActionResult> GetCity(Guid cityId)
        {
            
            var city = await _employerRepository.GetCity(cityId);

            if (city != null)
            {
                return Ok(city);
            }

            return NotFound("City not found");
        }

        [HttpGet]
        [Route("get-cities")]
        public async Task<IActionResult> GetCities()
        {
            var cities = await _employerRepository.GetCities();

            if (cities != null)
            {
                return Ok(cities);
            }

            return NotFound("No cities found");
        }
    }
}
