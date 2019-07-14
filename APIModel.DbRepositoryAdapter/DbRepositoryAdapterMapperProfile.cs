using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using APIModel.DbRepositoryAdapter.Dtos;
using APIModel.Domain.Models;

namespace APIModel.DbRepositoryAdapter
{
    public class DbRepositoryAdapterMapperProfile : Profile
    {
        public DbRepositoryAdapterMapperProfile()
        {
            CreateMap<ProdutoDto, Produto>()
                .ForMember(d => d.Nome, o => o.MapFrom(s => s.NomeProduto))
                .ForMember(d => d.Taxa, o => o.MapFrom(s => s.TaxaCl))
                .ForMember(d => d.TipoOperacao, o => o.MapFrom(s => (TipoOperacao)s.Operacao))
                .ForMember(d => d.ModalidadeVenda, o => o.MapFrom(s => (ModalidadeVenda)s.TipoVenda));
        }
    }
}
