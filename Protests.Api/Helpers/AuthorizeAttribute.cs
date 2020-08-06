using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext dontuse, HttpContext context)
        {
            var user = (AppUser)context.Items["AppUser"];
            if (user == null)
            {
                // not logged in
                return;
            }
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var a = (AppUser)context.HttpContext.Items["AppUser"];

        }
    }
}
