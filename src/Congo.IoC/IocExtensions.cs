using Congo.Application;
using Congo.Data;
using Congo.Domain;
using Congo.ExternalServices;
using Congo.Service;
using Congo.Shared;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Congo.IoC
{
    public static class IocExtensions
    {
        public static void AddIoCServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(
                typeof(Application.ServicesExtensions),
                typeof(Data.ServicesExtensions),
                typeof(ExternalServices.ServicesExtensions));

            services.AddOptions();

            services.AddDataServices(configuration);
            services.AddDomainServices(configuration);
            services.AddServiceServices(configuration);
            services.AddExternalServices(configuration);
            services.AddApplicationServices(configuration);
            services.AddSharedServices(configuration);

            services.AddMediatR(typeof(Domain.ServicesExtensions));
            services.AddMediatR(typeof(Service.ServicesExtensions));
            services.AddMediatR(typeof(Application.ServicesExtensions));
            services.AddMediatR(typeof(Data.ServicesExtensions));
            services.AddMediatR(typeof(ExternalServices.ServicesExtensions));
            services.AddMediatR(typeof(Shared.ServicesExtensions));
        }

    }
}
