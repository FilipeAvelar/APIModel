using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using APIModel.DbRepositoryAdapter;
using APIModel.Domain.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DbRepositoryAdapterServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddDbRepositoryAdapter(
            this IServiceCollection services,
            DbRepositoryAdapterConfiguration dbRepositoryAdapterConfiguration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (dbRepositoryAdapterConfiguration is null)
            {
                throw new ArgumentNullException(nameof(dbRepositoryAdapterConfiguration));
            }

            services.AddSingleton(dbRepositoryAdapterConfiguration);

            services.AddScoped<System.Data.IDbConnection>(d =>
            {
                return new SqlConnection(dbRepositoryAdapterConfiguration.SqlConnectionString);
            });

            services.AddScoped<IProdutoReadDbRepositoryAdapter, ProdutoDbRepositoryAdapter>();
            services.AddScoped<IProdutoWriteDbRepositoryAdapter, ProdutoDbRepositoryAdapter>();

            return services;
        }
    }
}
