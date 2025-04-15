using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.Data
{
    public static class ServicesExtensions
    {
        public static void AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            //string connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
            //services.AddDbContext<MyContext>(options => options.UseNpgsql(connectionString));
            ////Garante que a mesma instância da conexão seja usada durante toda a duração da solicitação e que ela seja fechada e liberada automaticamente ao final da solicitação
            //services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(connectionString));

            //services.AddTransient<IClassRepository, ClassRepository>();
        }

    }
}
