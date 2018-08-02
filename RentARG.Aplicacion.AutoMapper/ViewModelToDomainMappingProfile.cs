using AutoMapper;
using RentARG.Aplicacion.ViewModels;
using RentARG.Domain.Commands.Commands;

namespace RentARG.Aplicacion.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductoViewModel, ProductoCommand>()
                .ConstructUsing(c => new RegistrarProductoCommand(c));
        }
    }
}
