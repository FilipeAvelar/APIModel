using System;
using System.Collections.Generic;
using System.Text;

namespace APIModel.DbRepositoryAdapter.Dtos
{
    class ProdutoDto
    {
        /// <summary>
        /// Id do produto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string NomeProduto { get; set; }


        /// <summary>
        /// Taxa cliente
        /// </summary>
        public decimal TaxaCl { get; set; }

        /// <summary>
        /// Tipo de operação de crédito:
        /// 1 - Emprestimo
        /// 2 - Cartão
        /// </summary>
        public int Operacao { get; set; }

        /// <summary>
        /// Modalidade de venda:
        /// 1 - Digital 
        /// 2 - Padrão
        /// </summary>
        public int TipoVenda { get; set; }
    }
}
