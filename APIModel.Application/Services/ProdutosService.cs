using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using APIModel.Domain.Models;
using APIModel.Domain.Repository;
using APIModel.Domain.Services;

namespace APIModel.Application.Services
{
    /// <summary>
    /// Classe produtos service
    /// </summary>
    public class ProdutosService : IProdutosService
    {
        private readonly ILogger logger;       
        private readonly IProdutoWriteDbRepositoryAdapter produtoWriteDbRepositoryAdapter;
        private readonly IProdutoReadDbRepositoryAdapter produtoReadDbRepositoryAdapter;
        

        public ProdutosService(
            ILoggerFactory loggerFactory,             
            IProdutoWriteDbRepositoryAdapter produtoWriteDbRepositoryAdapter,
            IProdutoReadDbRepositoryAdapter produtoReadDbRepositoryAdapter)
        {

            logger = loggerFactory?.CreateLogger<ProdutosService>()
                ?? throw new ArgumentNullException(nameof(loggerFactory));
         
            this.produtoWriteDbRepositoryAdapter = produtoWriteDbRepositoryAdapter 
                ?? throw new ArgumentNullException(nameof(produtoWriteDbRepositoryAdapter));

            this.produtoReadDbRepositoryAdapter = produtoReadDbRepositoryAdapter 
                ?? throw new ArgumentNullException(nameof(produtoReadDbRepositoryAdapter));
           
        }
        
        public async Task<Produto> ObterProdutoPorIdAsync(int id)
        {
            logger.LogInformation($"Iniciando o método {nameof(ObterProdutoPorIdAsync)} " +
                "com os seguintes parametros: {Id}", id);

            var produto = await produtoReadDbRepositoryAdapter.ObterProdutoAsync(id);
           
            logger.LogInformation($"Finalizou o método {nameof(ObterProdutoPorIdAsync)} com sucesso.");

            return produto;

        }

        public async Task GravarProdutoAsync(Produto produto)
        {
            logger.LogInformation($"Iniciando o método {nameof(GravarProdutoAsync)} " +
                "com os seguintes parametros: {@Produto}", produto);

            await produtoWriteDbRepositoryAdapter.GravarProdutoAsync(produto);

            logger.LogInformation($"Finalizou o método {nameof(GravarProdutoAsync)} com sucesso.");           
        }
    }
}
