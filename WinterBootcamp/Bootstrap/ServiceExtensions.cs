using WinterBootcamp.Repository;
using WinterBootcamp.Repository.Interfaces;

namespace WinterBootcamp.Bootstrap
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            return services.AddSingleton<IApplicantRepository, ApplicantRepositoryList>();
        }
    }
}
