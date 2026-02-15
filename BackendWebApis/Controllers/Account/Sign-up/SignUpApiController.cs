using BackendWebApis.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendWebApis.Controllers.Account.Sign_up
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpApiController : ControllerBase
    {
        /// <summary>
        /// Signup
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("signup")]
        public ActionResult Signup(SignUp model)
        {
            return Ok(new {data = model, Message = "Signed up successfully."});
        }
    }
}
