using System.Threading.Tasks;

namespace RentARG.Infraestructura.Crosscutting.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
