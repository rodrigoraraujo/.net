using System;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;

namespace ClaimsAuthWithExternalSTS.IdentityModel
{
    public class SWClaimsAuthenticationManager : ClaimsAuthenticationManager
    {
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {            
            var name = incomingPrincipal.Identity.Name;

            if (String.IsNullOrWhiteSpace(name))
            {
                throw new SecurityException("Nome do usuário SenhaWeb está ausente.");
            }

            return CreatePrincipal(incomingPrincipal) as ClaimsPrincipal;
        }

        private IPrincipal CreatePrincipal(ClaimsPrincipal incomingPrincipal)
        {
            return new ClaimsPrincipal(new ClaimsIdentity(incomingPrincipal.Claims, "SenhaWeb"));
        }
    }
}