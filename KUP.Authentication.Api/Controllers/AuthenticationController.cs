using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KUP.Authentication.Business.Components.Definition;
using KUP.Authentication.Business.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KUP.Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {

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
        /// Authenticate a User
        /// </summary>
        /// <param name="userCred"></param>
        [HttpPost("authenticate", Name = "AuthenticateUser")]
        public IActionResult Post([FromBody] [ModelBinder]UserCredentials userCred)
        {
            if (userCred == null)
                return BadRequest();

            try
            {
                var result = _authenticationComponent.Authenticate(userCred.Username, userCred.Password);
                return new ObjectResult(result.ToString());
            }
            catch (Business.Exceptions.BusinessException bexc)
            {
                return BadRequest(bexc.Message);
            }
        }

    }
}
