using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RentARG.Aplicacion.Services;
using RentARG.Domain.CommandHandlers;
using RentARG.Domain.Commands;
using RentARG.Domain.Core.Bus;
using RentARG.Domain.Core.Events;
using RentARG.Domain.Core.Notifications;
using RentARG.Domain.EventHandlers;
using RentARG.Domain.Events;
using RentARG.Domain.Interfaces;
using RentARG.Infraestructura.Context;
using RentARG.Infraestructura.Crosscutting.Bus;
using RentARG.Infraestructura.Crosscutting.EventSourcing;
using RentARG.Infraestructura.Crosscutting.Identity;
using RentARG.Infraestructura.Crosscutting.Services;
using RentARG.Infraestructura.CrossCutting.Identity.Autorizations;
using RentARG.Repository;

namespace RentARG.Infraestructura.Crosscutting_IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddScoped<IProductoApiService, ProductoApiService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<ProductoRegisteredEvent>, ProductoEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegistrarProductoCommand>, ProductoCommandHandler>();

            // Infra - Data
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IUnitOfWork, Infraestructura.UnitOfWork.UnitOfWork>();
            services.AddScoped<RentARGContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<RentARGSQLContext>();

            // Infra - Identity Services
            services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            services.AddScoped<IUser, User>();
        }
    }

}
