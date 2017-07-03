using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Web;

namespace ClaimsAuthWithExternalSTS.IdentityModel
{
    public class SWClaims
    {
        private ClaimsPrincipal claims;

        private static SWClaims swClaims = null;

        private string GetClaimValue(string claimType)
        {
            return claims.FindFirst(claimType).Value;
        }

        public ClaimsPrincipal Claims { get { return this.claims; } }
        public string NomePessoa { get { return GetClaimValue(SWClaimsTypes.NomePessoa); } }
        public string NomePessoaRepresentada { get { return GetClaimValue(SWClaimsTypes.NomePessoaRepresentada); } }        
        public string CodigoPessoaRepresentada { get { return GetClaimValue(SWClaimsTypes.CodigoPessoaRepresentada); } }
        public string TipoPessoaRepresentada { get { return GetClaimValue(SWClaimsTypes.TipoPessoaRepresentada); } }
        public string IndicadorRepresentadoExisteBP { get { return GetClaimValue(SWClaimsTypes.IndicadorRepresentadoExisteBP); } }
        public string IndicadorRepresentadoExisteSWEB { get { return GetClaimValue(SWClaimsTypes.IndicadorRepresentadoExisteSWEB); } }
        public string CodigoPessoa { get { return GetClaimValue(SWClaimsTypes.CodigoPessoa); } }

        private SWClaims()
        {
            var principal = Thread.CurrentPrincipal;

            if (!principal.Identity.IsAuthenticated)
                throw new SecurityException("Usuário não autenticado.");

            if (principal.Identity.AuthenticationType != "SenhaWeb")
                throw new SecurityException("Tipo de autenticação não é poe SenhaWeb.");

            claims = principal as ClaimsPrincipal;
        }

        public static SWClaims GetInstance()
        {
            if (swClaims == null)
            {
                swClaims = new SWClaims();
            }

            return swClaims;
        }
    }
}