using Microsoft.AspNetCore.Http;
using RentARG.Domain.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;

namespace RentARG.Infraestructura.Crosscutting.Identity
{
    public class User : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public User(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => _accessor.HttpContext.User.Identity.Name;

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }

        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }


    }
}
