using AutoMapper;
using RentARG.Aplicacion.ViewModels;
using RentARG.Domain;

namespace RentARG.Aplicacion.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Producto, ProductoViewModel>();
        }
    }
}
