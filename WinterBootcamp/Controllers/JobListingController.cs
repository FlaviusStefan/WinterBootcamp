using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinterBootcamp.Entities;
using WinterBootcamp.Repository;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobListingController : ControllerBase
    {
        private readonly IJobListingRepository _jobListingRepository;

        public JobListingController(IJobListingRepository jobListingRepository)
        {
            _jobListingRepository = jobListingRepository ?? throw new ArgumentNullException(nameof(jobListingRepository));
        }


        [HttpPost]
        public async Task<IActionResult> AddJobListingForAnEmployer([FromBody] JobListing jobListing)
        {
            var isSuccessful = await _jobListingRepository.AddJobListingForAnEmployer(jobListing);
            return Ok(isSuccessful);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobListingsForAnEmployer(Guid employerId)
        {
            var result = await _jobListingRepository.GetJobListingsForAnEmployer(employerId);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJobListing(Guid jobListingId)
        {
            var isSuccesful = await _jobListingRepository.DeleteJobListing(jobListingId);
            return Ok(isSuccesful);
        }

        

    }
}
