using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimsTransformationPrincipalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SetPrincipal();
            UsePrincipal();
        }

        private static void UsePrincipal()
        {
            ShowCastle();
        }

        [ClaimsPrincipalPermission(SecurityAction.Demand, Operation = "Show", Resource = "Castle")]
        static void ShowCastle()
        {
            Console.WriteLine("Ahh wonderful...");
        }

        private static void SetPrincipal()
        {

            var p = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            Thread.CurrentPrincipal = FederatedAuthentication.FederationConfiguration.IdentityConfiguration.ClaimsAuthenticationManager.Authenticate("none", p) as IPrincipal;
        }
    }
}
