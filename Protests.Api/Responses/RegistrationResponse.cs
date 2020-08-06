using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Responses
{
    public class RegistrationResponse
    {
        public string Token { get; set; }
        public AppUser User { get; set; }

        public RegistrationResponse(AppUser user, string token)
        {
            this.User = user;
            this.Token = token;
        }
    }
}
