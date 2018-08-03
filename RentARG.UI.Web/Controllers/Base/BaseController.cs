using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentARG.Domain.Core.Notifications;

namespace RentARG.UI.Web.Controllers.Base
{
    public class BaseController : Controller
    {
        private readonly DomainNotificationHandler _notifications;

        public BaseController(INotificationHandler<DomainNotification> notifications)
        {
            _notifications = (DomainNotificationHandler)notifications;
        }

        public bool IsValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
    }
}
