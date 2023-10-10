using Microsoft.AspNetCore.Mvc;
using WinterBootcamp.Entities;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Repository
{
    // Lista
    public class ApplicantRepositoryList : IApplicantRepository
    {
        
        private List<Applicant> Applicants { get; set; } = null!;

        public ApplicantRepositoryList()
        {
            Applicants = new List<Applicant>();
        }

        public async Task<bool> AddApplicant(Applicant applicant)
        {
            applicant.ApplicantId = Guid.NewGuid(); 
            Applicants.Add(applicant);
            return true;
        }
        public async Task<List<Applicant>> GetAllApplicantsForEmployer(Guid emplyerId)
        {
            return Applicants.Where(applicant => applicant.EmployerId == emplyerId)
                             .ToList();
        }
        public async Task<List<Applicant>> GetAllApplicantsForJobListing(Guid jobListingId)
        {
            return Applicants.Where(applicant => applicant.JobListingId == jobListingId)
                             .ToList();
        }
    }

    // Baza de Date
    //public class ApplicantRepositoryDataStore : IApplicantRepository
    //{

    //}
}
