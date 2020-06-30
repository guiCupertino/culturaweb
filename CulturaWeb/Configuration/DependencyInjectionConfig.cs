using AutoMapper;
using CulturaWeb.Domain.Notification;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Domain.Service;
using CulturaWeb.Repository.EF;
using Microsoft.Extensions.DependencyInjection;

namespace CulturaWeb.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencias(this IServiceCollection services)
        {

            services.AddScoped<IRepositoryAluno, RepositoryAluno>();
            services.AddScoped<IRepositoryEditora, RepositoryEditora>();
            services.AddScoped<IRepositoryEmprestimo, RepositoryEmprestimo>();
            services.AddScoped<IRepositoryLivro, RepositoryLivro>();
            services.AddScoped<IRepositoryGenero, RepositoryGenero>();
            services.AddScoped<IRepositoryFuncionario, RepositoryFuncionario>();
            services.AddScoped<IRepositorySetor, RepositorySetor>();

            services.AddScoped<IServiceAluno, ServiceAluno>();
            services.AddScoped<IServiceEditora, ServiceEditora>();
            services.AddScoped<IServiceEmprestimo, ServiceEmprestimo>();
            services.AddScoped<IServiceFuncionario, ServiceFuncionario>();
            services.AddScoped<IServiceGenero, ServiceGenero>();
            services.AddScoped<IServiceLivro, ServiceLivro>();
            services.AddScoped<IServiceSetor, ServiceSetor>();
            services.AddScoped<IServiceSetor, ServiceSetor>();

            services.AddScoped<IServiceNotificador, ServiceNotificador>();

            //configura o mapper para converter os objetos.
            var config = new AutoMapperConfig().Configure();
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
