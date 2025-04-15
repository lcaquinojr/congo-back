using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.Service
{
    public static class ServicesExtensions
    {
        public static void AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<IInterface, ClassService>();
        }

    }
}
