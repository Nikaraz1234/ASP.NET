using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyWebApp.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
        if (user == null)
        {
            return null;
        }
        var claim = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName);
        return claim?.Value;
        }
    }
}