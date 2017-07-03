using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaimsPrincipalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupPrincipal();
            UsePrincipalLegacy();
            UsePrincipalNewCode();
        }

        private static void UsePrincipalNewCode()
        {
            //var p = Thread.CurrentPrincipal;
            //var cp = p as ClaimsPrincipal;

            var cp = ClaimsPrincipal.Current;

            var email = cp.FindFirst(ClaimTypes.Email).Value;
            Console.WriteLine(email);
        }

        private static void UsePrincipalLegacy()
        {
            var p = Thread.CurrentPrincipal;

            Console.WriteLine(p.Identity.Name);
            Console.WriteLine(p.IsInRole("admin"));
        }

        private static void SetupPrincipal()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "Rodrigo"),
                new Claim(ClaimTypes.Email, "rodrigo@teste.com.br"),
                new Claim(ClaimTypes.Role, "admin"),
                new Claim("http://myclaims/location", "São Paulo")
            };

            var id = new ClaimsIdentity(claims, "Console App", ClaimTypes.Name, ClaimTypes.Role);
            Console.WriteLine(id.IsAuthenticated);

            var p = new ClaimsPrincipal(id);
            Thread.CurrentPrincipal = p;
        }
    }
}
