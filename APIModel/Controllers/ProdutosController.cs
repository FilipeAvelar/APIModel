using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIModel.Domain.Models;
using APIModel.Domain.Services;
using APIModel.Dtos;
using APIModel.WebApi.Dtos;

namespace APIModel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosService produtosService;
        private readonly IMapper mapper;

        public ProdutosController(
            IProdutosService produtosService, 
            IMapper mapper)
        {
            this.produtosService = produtosService ?? 
                throw new ArgumentNullException(nameof(produtosService));

            this.mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Obter produto por Id.
        /// </summary>
        /// <response code="200">Detalhes do produto.</response>
        /// <response code="400">
        ///     Parametros incorretos ou limite de utilização excedido.
        /// </response>
        /// <response code="500">Erro interno.</response>
        [HttpGet(), AllowAnonymous]
        [ProducesResponseType(typeof(ProdutoGetResult), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterProdutoAsync(
                    [FromQuery] ProdutoGet produtosGet)
        {
            var produto = await produtosService.ObterProdutoPorIdAsync(produtosGet.Id);

            ProdutoGetResult produtosGetResults = mapper.Map<ProdutoGetResult>(produto);

            return Ok(produtosGetResults);
        }

        /// <summary>
        /// Gravar produto
        /// </summary>
        /// <response code="200">Detalhes do produto.</response>
        /// <response code="400">
        ///     Parametros incorretos ou limite de utilização excedido.
        /// </response>
        /// <response code="500">Erro interno.</response>
        [HttpPost(), AllowAnonymous]
        [ProducesResponseType(typeof(ProdutoGetResult), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GravarProdutoAsync(
            [FromBody] ProdutoPost produtoPost)
        {
            var produto = mapper.Map<Produto>(produtoPost);

            await produtosService.GravarProdutoAsync(produto);
            
            return Ok();
        }
        
    }
}
