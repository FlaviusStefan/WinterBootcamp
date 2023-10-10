using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WinterBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobListingController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddJobListingForAnEmployer()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteJobListingForAnEmployer()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> GetJobListingsForAnEmployer()
        {
            throw new NotImplementedException();
        }

    }
}
