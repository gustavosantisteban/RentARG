using MediatR;
using RentARG.Domain.CommandHandlers.BaseCommand;
using RentARG.Domain.Commands;
using RentARG.Domain.Core.Bus;
using RentARG.Domain.Core.Notifications;
using RentARG.Domain.Events;
using RentARG.Domain.Interfaces;
using RentARG.Repository;
using System.Threading;
using System.Threading.Tasks;

namespace RentARG.Domain.CommandHandlers
{
    public class ProductoCommandHandler : CommandHandler, IRequestHandler<RegistrarProductoCommand>
    {
        private readonly IProductoRepository productoRepository;
        private readonly IMediatorHandler Bus;
        private readonly Producto producto;

        public ProductoCommandHandler(IProductoRepository _productoRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      Producto _producto,
                                      INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            productoRepository = _productoRepository;
            producto = _producto;
            Bus = bus;
        }

        public Task Handle(RegistrarProductoCommand command, CancellationToken cancellationToken)
        {
            if (!command.IsValid())
            {
                NotifyValidationErrors(command);
                return Task.CompletedTask;
            }

            var producto = this.producto.RegistrarProducto(command);

            productoRepository.Add(producto);

            if (Commit())
            {
                Bus.RaiseEvent(new ProductoRegisteredEvent(producto.Id, producto.Nombre, producto.Descripcion));
            }

            return Task.CompletedTask;
        }

    }
}
