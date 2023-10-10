using WinterBootcamp.Entities;

namespace WinterBootcamp.Repository.Interfaces
{
    public interface IApplicantRepository
    {
        Task<bool> AddApplicant(Applicant applicant);
        Task<List<Applicant>> GetAllApplicantsForEmployer(Guid emplyerId);
        Task<List<Applicant>> GetAllApplicantsForJobListing(Guid jobListingId);
    }
}
