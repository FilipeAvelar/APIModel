using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIModel.WebApi.Dtos
{
    public class ProdutoPost
    {
        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// Valor do Produto
        /// </summary>
        public decimal Taxa { get; set; }

        /// <summary>
        /// Tipo de operação de crédito:
        /// 1 - Emprestimo
        /// 2 - Cartão
        /// </summary>
        public TipoOperacaoDto TipoOperacao { get; set; }

        /// <summary>
        /// Modalidade de venda:
        /// 1 - Digital 
        /// 2 - Padrão
        /// </summary>
        public ModalidadeVendaDto ModalidadeVenda { get; set; }
    }
}
