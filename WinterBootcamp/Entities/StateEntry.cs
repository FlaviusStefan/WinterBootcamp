namespace WinterBootcamp.Entities
{
    public class State
    {
        public Guid StateId { get; set; }
        public string StateName { get; set; }
        public Guid CountryId { get; set; }
    }

    public class StateDto
    {
        public string StateName { get; set; }
        public Guid CountryId { get; set; }
    }
}
