using Microsoft.AspNetCore.Mvc;
using webApiCrud.Services;


namespace webApiCrud.Controllers
{
    [ApiController]
    [Route("api/v1/Auth")]
    public class AuthController : Controller
    {

        [HttpPost]
        public IActionResult Auth(string userName, string passWord)
        {
            if (userName == "vitinho" && passWord == "123")
            {
                var token = TokenService.GenerateToken(new Models.ProductDescription());
                return Ok(token);
            }

            return BadRequest("Username or Password Invalid!");
        }

    }
}
