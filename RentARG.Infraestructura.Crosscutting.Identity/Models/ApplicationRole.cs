using Microsoft.AspNetCore.Identity;
using System;

namespace RentARG.Infraestructura.Crosscutting.Identity
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
        }

        // Add any custom Role properties/code here
    }
}
