using MediatR;
using RentARG.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace RentARG.Domain.EventHandlers
{
    public class ProductoEventHandler :
        INotificationHandler<ProductoRegisteredEvent>
    {
        public Task Handle(ProductoRegisteredEvent message, CancellationToken cancellationToken)
        {
            // Send some greetings e-mail

            return Task.CompletedTask;
        }

    }
}
