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

                if (!StringValues.IsNullOrEmpty(xForwardedForValues))
                {
                    var xForwardedFor = xForwardedForValues.ToString();
                    remoteIpAddress += " - xForwardfor: " + xForwardedFor;
                }

                StringValues xForwardedProtoValues;
                HttpContext.Request.Headers.TryGetValue("X-Forwarded-Proto", out xForwardedProtoValues);

                if (!StringValues.IsNullOrEmpty(xForwardedProtoValues))
                {
                    var xForwardedProto = xForwardedProtoValues.ToString();
                    remoteIpAddress += " - xForwardedProto: " + xForwardedProto;
                }

                StringValues xRealIpValues;

                HttpContext.Request.Headers.TryGetValue("X-Real-IP", out xRealIpValues);

                if (!StringValues.IsNullOrEmpty(xRealIpValues))
                {
                    var xRealIp = xRealIpValues.ToString();
                    remoteIpAddress += " - xRealIp: " + xRealIp;
                }

                var result = await _authenticationComponent.Authenticate(userCred.Username, userCred.Password, userCred.UserType, remoteIpAddress);
                return new ObjectResult(result);
            }
            catch (Business.Exceptions.BusinessException bexc)
            {
                return BadRequest(bexc.Message);
            }
        }

        //private string GetRemoteIPaddress()
        //{
        //    HttpContext.Request.

        //    string ipAddress = HttpContext.Request.HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //    if (!string.IsNullOrEmpty(ipAddress))
        //    {
        //        string[] addresses = ipAddress.Split(',');
        //        if (addresses.Length != 0)
        //        {
        //            return addresses[0];
        //        }
        //    }

        //    return context.Request.ServerVariables["REMOTE_ADDR"];

        //}

    }
}
