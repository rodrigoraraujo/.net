using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsTransformationPrincipalDemo
{
    class AuthorizationManager : ClaimsAuthorizationManager
    {
        public override bool CheckAccess(AuthorizationContext context)
        {
            var resource = context.Resource.First().Value;
            var action = context.Action.First().Value;

            if(action == "Show" && resource == "Castle")
            {
                var hasCastle = context.Principal.HasClaim("http://myclaims/hasCastle", "True");

                return hasCastle;
            }

            return false;
        }
    }
}
