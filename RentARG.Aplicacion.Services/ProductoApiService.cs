using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentARG.Aplicacion.ViewModels;
using RentARG.Domain.Commands;
using RentARG.Domain.Core.Bus;
using RentARG.Repository;
using System;
using System.Collections.Generic;

namespace RentARG.Aplicacion.Services
{
    public class ProductoApiService : IProductoApiService
    {
        private readonly IMapper mapper;
        private readonly IProductoRepository productoRepository;
        private readonly IEventStoreRepository eventStoreRepository;
        private readonly IMediatorHandler bus;

        public ProductoApiService(IMapper _mapper,
                                  IProductoRepository _productoRepository,
                                  IMediatorHandler _bus,
                                  IEventStoreRepository _eventStoreRepository)
        {
            mapper = _mapper;
            productoRepository = _productoRepository;
            bus = _bus;
            eventStoreRepository = _eventStoreRepository;
        }

        public IEnumerable<ViewModel> GetAll()
        {
            return productoRepository.GetAll().ProjectTo<ProductoViewModel>();
        }

        public ViewModel GetById(Guid id)
        {
            return mapper.Map<ProductoViewModel>(productoRepository.GetById(id));
        }

        public void Register(ProductoViewModel viewModel)
        {
            var registrarProductoCommand = mapper.Map<ProductoCommand>(viewModel);
            bus.SendCommand(registrarProductoCommand);
        }

        public void Update(ProductoViewModel viewModel)
        {
            var actualizarProductoCommand = mapper.Map<ProductoCommand>(viewModel);
            bus.SendCommand(actualizarProductoCommand);
        }

        public void Remove(Guid id)
        {
            var eliminarProductoCommand = new ProductoCommand();
            bus.SendCommand(eliminarProductoCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
