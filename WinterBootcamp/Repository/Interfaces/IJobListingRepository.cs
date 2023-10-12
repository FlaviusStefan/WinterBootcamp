using WinterBootcamp.Entities;

namespace WinterBootcamp.Repository.Interfaces
{
    public interface IJobListingRepository
    {
        Task<bool> AddJobListingForAnEmployer(JobListing jobListing);
        Task<List<JobListing>> GetJobListingsForAnEmployer(Guid employerId);
        Task<bool> DeleteJobListing(Guid jobListing);




    }
}
