using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APIModel.Domain.Models;

namespace APIModel.Domain.Repository
{
    public interface IProdutoWriteDbRepositoryAdapter
    {
        /// <summary>
        /// Grava o produto 
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>Produto gravado</returns>
        Task<Produto> GravarProdutoAsync(Produto produto);
    }
}
