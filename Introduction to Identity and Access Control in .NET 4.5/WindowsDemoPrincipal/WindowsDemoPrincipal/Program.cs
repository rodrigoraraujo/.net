using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = WindowsIdentity.GetCurrent();
            Console.WriteLine(id.Name);

            var account = new NTAccount(id.Name);
            var sid = account.Translate(typeof(SecurityIdentifier));
            Console.WriteLine(sid.Value);

            Console.WriteLine($"Authenticated: {id.IsAuthenticated}");

            foreach (var group in id.Groups.Translate(typeof(NTAccount)))
            {
                Console.WriteLine(group);
            }
        }
    }
}
