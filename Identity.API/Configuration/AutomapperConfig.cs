using AutoMapper;
using Identity.API.ViewModels;
using Identity.Business.Models;

namespace Identity.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
        }
    }
}