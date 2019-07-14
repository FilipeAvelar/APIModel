using System;
using System.Diagnostics.CodeAnalysis;
using APIModel.Application.Services;
using APIModel.Domain.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IProdutosService, ProdutosService>();

            return services;
        }
    }
}
