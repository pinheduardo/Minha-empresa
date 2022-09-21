using AutoMapper;
using MinhaEmpresa.Api.Dtos;
using MinhaEmpresa.Business.Models;

namespace MinhaEmpresa.Api.Configuration
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Example, ExampleDto>().ReverseMap();
        }
    }
}
