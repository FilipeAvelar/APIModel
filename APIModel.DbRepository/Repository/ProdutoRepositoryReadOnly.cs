using System.Threading.Tasks;
using APIModel.Domain.Models;
using APIModel.Domain.Repository;

namespace APIModel.DbRepository.Repository
{
    public class ProdutoRepositoryReadOnly : IProdutoRepositoryReadOnly
    {
        public async Task<Produto> ObterProdutoPorId(int id)
        {
            var produto = new Produto()
            {
                Id = 1,
                Nome = "Produto teste"
            };

            return produto;
        }
    }
}
