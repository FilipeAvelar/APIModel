using System;
using System.Diagnostics.CodeAnalysis;
using APIModel.DbRepository;
using APIModel.DbRepository.Repository;
using APIModel.Domain.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DbRepositoryServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddDbRepository(
            this IServiceCollection services, 
            DbRepositoryConfiguration dbRepositoryConfiguration)
        {            
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (dbRepositoryConfiguration is null)
            {
                throw new ArgumentNullException(nameof(dbRepositoryConfiguration));
            }

            services.AddSingleton(dbRepositoryConfiguration);

            services.AddScoped<IProdutoRepositoryReadOnly, ProdutoRepositoryReadOnly>();

            return services;
        }
    }
}

