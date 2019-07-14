using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APIModel.Domain.Models;

namespace APIModel.Domain.Repository
{
    public interface IProdutoReadDbRepositoryAdapter
    {
        /// <summary>
        /// Retorna o produto por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Dados do produto solicitado</returns>
        Task<Produto> ObterProdutoAsync(int id);
    }
}
