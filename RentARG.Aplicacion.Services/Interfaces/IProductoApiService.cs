using RentARG.Aplicacion.ViewModels;
using System;

namespace RentARG.Aplicacion.Services
{
    public interface IProductoApiService : IApiService
    {
        void Register(ProductoViewModel viewModel);
        void Update(ProductoViewModel viewModel);
        void Remove(Guid id);
    }
}
