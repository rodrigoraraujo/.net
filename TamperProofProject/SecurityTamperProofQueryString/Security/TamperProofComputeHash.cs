using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace SecurityTamperProofQueryString.Security
{
    public class TamperProofComputeHash
    {
        private static readonly string RSAKey64 = @"MD8CAQACCQCfdjealz9+VwIDAQABAghnBRT+QYgxoQIFANOh0gUCBQDA5HGrAgUAt/YKIQIEIzLMhwIFAINp1I8=";
        private static string ComputeHash(string queryString)
        {
            byte[] keyRSA64 = Encoding.UTF8.GetBytes(RSAKey64);
            using (HMACSHA256 kha = new HMACSHA256(keyRSA64))
            {
                return BitConverter.ToString(kha.ComputeHash(Encoding.UTF8.GetBytes(queryString))).Replace("-", "");
            }
        }

        public static bool IsValidQueryString(NameValueCollection queryString)
        {
            if (queryString.AllKeys.Count() == 0)
                return true;

            var keyName = queryString.OfType<string>().FirstOrDefault<string>(v => v == "key");

            var hashedQueryString = GetHashedQueryString(queryString, keyName);

            if (string.IsNullOrEmpty(keyName))
                throw new SecurityException("O parâmetro de validação não foi informado");

            var keyValue = queryString[keyName];

            if (!hashedQueryString.Equals(keyValue))
                throw new SecurityException("Os valores e/ou variáveis não podem ser alterados.");

            return true;
        }

        private static string GetHashedQueryString(NameValueCollection queryString, string keyName)
        {
            var varAndValues = new StringBuilder();
            foreach (var queryVar in queryString.AllKeys)
                if (!queryVar.Equals(keyName))
                    varAndValues.Append($"{queryVar}={queryString[queryVar]}");

            return ComputeHash(varAndValues.ToString());
        }

        public static RouteValueDictionary SetHashQueryString(dynamic routeValues)
        {            
            var varAndValues = new StringBuilder();
                        
            var routeDictionary = new RouteValueDictionary();

            foreach (var prop in routeValues.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var name = prop.Name;
                var value = prop.GetValue(routeValues, null);

                varAndValues.Append($"{name}={value}");
                routeDictionary.Add(name, value);
            }

            string computedHash = ComputeHash(varAndValues.ToString());

            routeDictionary.Add("key", computedHash);

            return routeDictionary;
        }
        public static void SetHashQueryString(ref NameValueCollection queryString)
        {
            var varAndValues = new StringBuilder();

            foreach (var queryVar in queryString.AllKeys)
                varAndValues.Append($"{queryVar}={queryString[queryVar]}");

            string computedHash = ComputeHash(varAndValues.ToString());

            queryString["key"] = computedHash;
        }
    }
}
