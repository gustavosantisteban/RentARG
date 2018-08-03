using System.Threading.Tasks;

namespace RentARG.Infraestructura.Crosscutting.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
