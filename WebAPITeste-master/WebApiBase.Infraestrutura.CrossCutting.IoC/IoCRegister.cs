using Microsoft.Extensions.DependencyInjection;
using WebApiBase.Aplicacao.Nucleo.Interfaces;
using WebApiBase.Aplicacao.Servicos;
using WebApiBase.Dominio.Nucleo.Interfaces.Repositorios;
using WebApiBase.Dominio.Nucleo.Interfaces.Servicos;
using WebApiBase.Dominio.Servicos.Servicos;
using WebApiBase.Infraestrutura.CrossCutting.Adaptadores;
using WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper;
using WebApiBase.Infraestrutura.Repositorios.Repositorios;

namespace WebApiBase.Infraestrutura.CrossCutting.IoC
{
    public static class IoCRegister
    {
        public static void RegisterModules(this IServiceCollection services)
        {
            RegisterTransient(services);
            RegisterScoped(services);
            RegisterSingleton(services);

        }

        static void RegisterSingleton(IServiceCollection services)
        {
        }

        static void RegisterScoped(IServiceCollection services)
        {
            //todo: implementar todos os métodos para registrar application services, services, repositories e mappers
            RegisterApplicationServices(services);
            RegisterServices(services);
            RegisterRepositories(services);
            RegisterMappers(services);

        }

        static void RegisterTransient(IServiceCollection services)
        {
        }

        static void RegisterMappers(IServiceCollection services)
        {
            services.AddScoped<IMapperAtividade, MapperAtividade>();
        }

        static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IRepositoryAtividade, RepositoryAtividade>();
        }

        static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IServiceAtividade, ServiceAtividade>();
        }

        static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationServiceAtividade, ApplicationServiceAtividade>();
        }

    }
}
