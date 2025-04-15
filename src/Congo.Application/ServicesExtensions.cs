using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.Application
{
    public static class ServicesExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // reservado para futuros registros de serviços
            //services.AddTransient<IClasse, Classe>();            
        }
    }
}
