using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DragonWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth/")]
    [EnableCors("any")]
    public class AuthController : Controller
    {
        [AllowAnonymous]
        [Route("validate")]
        [HttpGet]
        public ActionResult Validate()
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("token", Request.Headers["token"])
            });
                var result = client.PostAsync("https://localhost:44387/authentication/validate", content).Result;
                if (result.IsSuccessStatusCode)
                    return Ok();
                else
                    return Unauthorized();
            }

        }
    }
}
