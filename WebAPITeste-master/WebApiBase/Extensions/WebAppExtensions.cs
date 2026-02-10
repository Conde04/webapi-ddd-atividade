using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebApiBase.Infraestrutura.CrossCutting.Adaptadores.Profiles;
using WebApiBase.Infraestrutura.Data;

namespace WebApiBase.Extensions
{
    public static class WebAppExtensions
    {
        public static void ConfigureControllers(this IServiceCollection services)
        {
            services.AddControllers()
                    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config => config.AddMaps(typeof(IBaseProfile).Assembly));
        }

        public static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddDbContext<InMemoryContext>(opt => opt.UseInMemoryDatabase("AtividadesDb"));
        }
    }
}
