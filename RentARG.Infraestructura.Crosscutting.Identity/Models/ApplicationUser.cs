using Microsoft.AspNetCore.Identity;
using System;

namespace RentARG.Infraestructura.Crosscutting.Identity
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
