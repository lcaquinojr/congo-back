using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.Domain
{
    public static class ServicesExtensions
    {
        public static void AddDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            //AddDomainValidations(services);
            services.AddSpecsAndRules();
            services.AddConfiguracoes(configuration);
        }
        public static void AddSpecsAndRules(this IServiceCollection services)
        {
            //services.AddScoped<IInterface, Class>();
        }
        public static void AddConfiguracoes(this IServiceCollection services, IConfiguration configuration)
        {
            // reservado para inclusão de configurações do tipo IOptions
        }
    }
}
