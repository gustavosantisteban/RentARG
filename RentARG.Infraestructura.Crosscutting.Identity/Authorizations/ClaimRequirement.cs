using Microsoft.AspNetCore.Authorization;

namespace RentARG.Infraestructura.CrossCutting.Identity.Autorizations
{
    public class ClaimRequirement : IAuthorizationRequirement
    {
        public ClaimRequirement(string claimName, string claimValue)
        {
            ClaimName = claimName;
            ClaimValue = claimValue;
        }

        public string ClaimName { get; set; }
        public string ClaimValue { get; set; }
    }
}
