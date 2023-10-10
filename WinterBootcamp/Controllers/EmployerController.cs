using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinterBootcamp.Entities;

namespace WinterBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register()
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            throw new NotImplementedException();
        }


        //Tre sa faci si metode get pt toate astea
        [HttpGet]
        [Route("add-country")]
        public async Task<IActionResult> AddCountry([FromBody] Country country)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("add-state")]
        public async Task<IActionResult> AddState([FromBody] State state)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("add-city")]
        public async Task<IActionResult> AddCity([FromBody] City city)
        {
            throw new NotImplementedException();
        }
    }
}
