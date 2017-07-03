using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsTransformationPrincipalDemo
{
    class ClaimsTransformer : ClaimsAuthenticationManager
    {
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {
            var name = incomingPrincipal.Identity.Name;

            if (String.IsNullOrWhiteSpace(name))
            {
                throw new SecurityException("Name claim is missing");
            }

            return CreatePrincipal(name);
        }
        
        private ClaimsPrincipal CreatePrincipal(string name)
        {
            var hasCastle = false;

            if (name == "REDE\\p016935")
            {
                hasCastle = true;
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, name),
                new Claim("http://myclaims/hasCastle", hasCastle.ToString())
            };

            return new ClaimsPrincipal(new ClaimsIdentity(claims, "Custom"));
        }
    }
}
