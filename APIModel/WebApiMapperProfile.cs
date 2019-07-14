using AutoMapper;
using APIModel.Domain.Models;
using APIModel.Dtos;

namespace APIModel.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Produto, ProdutoGetResult>();
        }
    }
}

