namespace WinterBootcamp.Entities
{
    public class JobListing
    {
        public Guid JobListingId { get; set; }
        public Guid EmployerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
