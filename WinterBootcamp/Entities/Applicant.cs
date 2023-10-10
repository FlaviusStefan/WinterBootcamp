namespace WinterBootcamp.Entities
{
    public class Applicant
    {
        public Guid? ApplicantId { get; set; }
        public Guid EmployerId { get; set; }
        public Guid JobListingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public Guid CountryId { get; set; }
        public Guid? StateId { get; set; }
        public Guid CityId { get; set; }
    }    
}