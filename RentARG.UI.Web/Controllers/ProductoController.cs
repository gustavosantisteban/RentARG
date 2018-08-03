using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentARG.Aplicacion.Services;
using RentARG.Domain.Core.Notifications;
using RentARG.UI.Web.Controllers.Base;

namespace RentARG.UI.Web.Controllers
{
    public class ProductoController : BaseController
    {
        private readonly IProductoApiService productoApiService;

        public ProductoController(IProductoApiService _productoApiService,
                                  INotificationHandler<DomainNotification> notifications)
                    : base(notifications)
        {
            productoApiService = _productoApiService;
        }

        [HttpGet]
        [Route("productos/mostrar-todos")]
        public IActionResult Index()
        {
            return View(productoApiService.GetAll());
        }
    }
}