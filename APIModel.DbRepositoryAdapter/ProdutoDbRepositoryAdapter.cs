using AutoMapper;
using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;
using APIModel.DbRepositoryAdapter.Dtos;
using APIModel.Domain.Models;
using APIModel.Domain.Repository;

namespace APIModel.DbRepositoryAdapter
{
    public class ProdutoDbRepositoryAdapter 
        : IProdutoReadDbRepositoryAdapter, IProdutoWriteDbRepositoryAdapter
    {
        private readonly IDbConnection dbConnection;
        private readonly IMapper mapper;

        static ProdutoDbRepositoryAdapter() => SqlMapper.AddTypeMap(typeof(string), DbType.AnsiString);

        public ProdutoDbRepositoryAdapter(IDbConnection dbConnection, IMapper mapper)
        {
            this.dbConnection = dbConnection
                ?? throw new ArgumentNullException(nameof(dbConnection));
            this.mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Produto> ObterProdutoAsync(int id)
        {
            var query = "@";

            var parametros = new DynamicParameters();
            parametros.Add("Id", id);

            var produtoDto =
                await dbConnection.QueryFirstOrDefaultAsync<ProdutoDto>(query, parametros);

            var produto = mapper.Map<Produto>(produtoDto);

            return produto;

        }

        public async Task<Produto> GravarProdutoAsync(Produto produto)
        {
            var query = "@";

            var produtoDto = mapper.Map<ProdutoDto>(produto);

            await dbConnection.ExecuteScalarAsync(query, produtoDto);

            return produto;
        }

    }
}
