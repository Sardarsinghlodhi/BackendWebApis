using BackendWebApis.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendWebApis.Controllers.Account.Sign_up
{
    [Route("api/signup")]
    [ApiController]
    public class SignUpApiController : ControllerBase
    {
        /// <summary>
        /// Signup
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Signup(SignUp model)
        {
            return Ok(new {data = model, Message = "Signed up successfully."});
        }
    }
}
