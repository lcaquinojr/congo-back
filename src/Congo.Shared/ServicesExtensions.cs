using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.Shared
{
    public static class ServicesExtensions
    {
        public static void AddSharedServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddSingleton(typeof(LogEvent<>));
        }

    }
}
