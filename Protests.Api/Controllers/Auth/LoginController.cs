using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Protests.Api.Requests;
using Protests.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Controllers.Auth
{
    [Route("api/auth/login")]
    public class LoginController : BaseController
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public LoginController(
            IAuthService authService,
            IMapper mapper
        )
        {
            this.mapper = mapper;
            this.authService = authService;
        }

        [HttpPost]
        public ActionResult<string> Login(LoginRequest request)
        {
            var token = this.authService.Login(request.Email, request.Password);
            return token;
        }
    }
}
