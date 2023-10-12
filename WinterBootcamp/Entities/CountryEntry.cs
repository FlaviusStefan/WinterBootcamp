namespace WinterBootcamp.Entities
{
    public class Country
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class CountryDto
    {
        public string CountryName { get; set; }
    }
}