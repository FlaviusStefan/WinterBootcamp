using WinterBootcamp.Entities;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Repository
{
    public class EmployerRepository : IEmployerRepository
    {
        private List<Employer> Employers { get; set; } = null!;

        public EmployerRepositoryList()
        {
            Employers = new List<Employer>();
        }

        

    }
}
