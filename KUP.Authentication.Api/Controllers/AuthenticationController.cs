using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KUP.Authentication.Business.Components.Definition;
using KUP.Authentication.Business.Models;
using Microsoft.Extensions.Primitives;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KUP.Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        // this is very bad code.. 
        int myInt = 0;
        // more bad code
        
        private readonly IAuthenticationComponent _authenticationComponent;
        /// <summary>
        /// Api Controller Constructor
        /// </summary>
        /// <param name="authenticationComponent"></param>
        public AuthenticationController(IAuthenticationComponent authenticationComponent)
        {
            _authenticationComponent = authenticationComponent;
        }

        /// <summary>
        /// Test Get Gethod
        /// </summary>
        /// <returns></returns>
        [HttpGet("test", Name = "Test Method")]
        public IActionResult Get()
        {
            return new ObjectResult("Hello World");
        }
        /// <summary>
        /// Authenticate a User [Student or Faculty]
        /// </summary>
        /// <param name="userCred"></param>
        [HttpPost("authenticate", Name = "AuthenticateUser")]
        public async Task<IActionResult> Post([FromBody] [ModelBinder]UserCredentials userCred)
        {
            if (userCred == null)
                return BadRequest();

            try
            {
                var remoteIpAddress = HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
                StringValues xForwardedForValues;
                HttpContext.Request.Headers.TryGetValue("X-Forwarded-For", out xForwardedForValues);

                StringValues xRealIpValues;

                HttpContext.Request.Headers.TryGetValue("X-Real-IP", out xRealIpValues);

                if (!StringValues.IsNullOrEmpty(xRealIpValues))
                {
                    var xRealIp = xRealIpValues.ToString();
                    remoteIpAddress = xRealIp;
                }

                var result = await _authenticationComponent.Authenticate(userCred.Username, userCred.Password, userCred.UserType, remoteIpAddress);
                return new ObjectResult(result);
            }
            catch (Business.Exceptions.BusinessException bexc)
            {
                return BadRequest(bexc.Message);
            }
        }
    }
}
