using RentARG.Domain.Core.Commands;
using RentARG.Domain.Core.Events;
using System.Threading.Tasks;

namespace RentARG.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
