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
        [Route("applicant")]
        public async Task<IActionResult> AddApplicant([FromBody] Applicant applicant)
        {
            var isSuccessful = await _applicantRepository.AddApplicant(applicant);
            return Ok();
        }

        [HttpGet]
        [Route("employer/applicants/{employerId}")]
        public async Task<IActionResult> GetAllApplicantsForEmployer(string employerId)
        {

            if (!Guid.TryParse(employerId, out var id))
                return BadRequest("invalid guid");

            var result = await _applicantRepository.GetAllApplicantsForEmployer(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("joblisting/applicants")]
        public async Task<IActionResult> GetAllApplicantsForJobListing()
        {
            throw new NotImplementedException();
        }


    }
}