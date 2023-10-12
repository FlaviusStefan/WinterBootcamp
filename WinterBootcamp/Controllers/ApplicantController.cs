using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinterBootcamp.Entities;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository ?? throw new ArgumentNullException(nameof(applicantRepository));
        }

        [HttpPost]
        public async Task<IActionResult> AddApplicant([FromBody] Applicant applicant)
        {
            var isSuccessful = await _applicantRepository.AddApplicant(applicant);
            return Ok();
        }

        [HttpGet]
        [Route("employer/{employerId}")]
        public async Task<IActionResult> GetAllApplicantsForEmployer(Guid employerId)
        {
            var result = await _applicantRepository.GetAllApplicantsForEmployer(employerId);
            return Ok(result);
        }

        [HttpGet]
        [Route("joblisting/{joblistingId}")]
        public async Task<IActionResult> GetAllApplicantsForJobListing(Guid jobListingId)
        {          
            var result = await _applicantRepository.GetAllApplicantsForEmployer(jobListingId);
            return Ok(result);
        }
    }
}