using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Protests.Api.Requests;
using Protests.Api.Responses;
using Protests.Api.Services;
using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Controllers.Auth
{
    [Route("api/auth/register")]
    public class RegistrationController : BaseController
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public RegistrationController(
            IAuthService authService,
            IMapper mapper
        )
        {
            this.mapper = mapper;
            this.authService = authService;
        }

        [HttpPost]
        public ActionResult<RegistrationResponse> Register(RegistrationRequest request)
        {
            var user = this.mapper.Map<AppUser>(request);
            user = this.authService.Register(user);

            return new RegistrationResponse(user, "");
        }
    }
}
