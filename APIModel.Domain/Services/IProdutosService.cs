using System.Threading.Tasks;
using APIModel.Domain.Models;

namespace APIModel.Domain.Services
{
    public interface IProdutosService
    {
        /// <summary>
        /// Obter produto por id
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Detalhes do produto</returns>
        Task<Produto> ObterProdutoPorIdAsync(int id);

        /// <summary>
        /// Grava o produto 
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>Produto gravado</returns>
        Task GravarProdutoAsync(Produto produto);
    }
}
