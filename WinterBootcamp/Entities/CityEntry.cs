namespace WinterBootcamp.Entities
{
    public class City 
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
    }
}
