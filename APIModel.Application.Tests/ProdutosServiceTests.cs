using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using APIModel.Application.Services;
using APIModel.Domain.Models;
using APIModel.Domain.Repository;
using APIModel.Domain.Services;

namespace APIModel.Application.Tests
{
    public class ProdutosServiceTests
    {
        private readonly IProdutosService produtosService;            
        private readonly Mock<IProdutoWriteDbRepositoryAdapter> produtoWriteDbRepositoryAdapter;
        private readonly Mock<IProdutoReadDbRepositoryAdapter> produtoReadDbRepositoryAdapter;

        public ProdutosServiceTests()
        {
            produtoWriteDbRepositoryAdapter = new Mock<IProdutoWriteDbRepositoryAdapter>();
            produtoReadDbRepositoryAdapter = new Mock<IProdutoReadDbRepositoryAdapter>();

            produtosService = new ProdutosService(
                new LoggerFactory(),

                produtoWriteDbRepositoryAdapter.Object,
                produtoReadDbRepositoryAdapter.Object);
        }

        [Fact]
        [Trait(nameof(IProdutosService.ObterProdutoPorIdAsync), "Sucesso")]
        public async Task ObterProdutoPorIdAsync_Sucesso()
        {
            var expected = new Produto()
            {
                Id = 123,
                Nome = "Produto teste"
            };

            produtoReadDbRepositoryAdapter.Setup(
                x => x.ObterProdutoAsync(It.IsAny<int>()))
                .ReturnsAsync(expected);

            var produto = await produtosService.ObterProdutoPorIdAsync(123);

            Assert.Equal(produto.Id, expected.Id);
        }

        [Fact]
        [Trait(nameof(IProdutosService.ObterProdutoPorIdAsync), "Erro")]
        public async Task ObterProdutoPorIdAsync_Erro()
        {
            Assert.True(true);
        }
    }
}
