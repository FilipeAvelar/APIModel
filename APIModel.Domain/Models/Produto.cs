namespace APIModel.Domain.Models
{
    public class Produto
    {
        /// <summary>
        /// Id do produto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string Nome { get; set; }
        

        /// <summary>
        /// Taxa do produto
        /// </summary>
        public decimal Taxa { get; set; }

        /// <summary>
        /// Tipo de operação de crédito:
        /// 1 - Emprestimo
        /// 2 - Cartão
        /// </summary>
        public TipoOperacao TipoOperacao { get; set; }

        /// <summary>
        /// Modalidade de venda:
        /// 1 - Digital 
        /// 2 - Padrão
        /// </summary>
        public ModalidadeVenda ModalidadeVenda { get; set; }
    }
}
