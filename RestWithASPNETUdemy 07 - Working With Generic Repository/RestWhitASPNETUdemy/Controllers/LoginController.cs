using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestWhitASPNETUdemy.Busines;
using RestWhitASPNETUdemy.Data.VO;

namespace RestWhitASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LoginController : ControllerBase
    {

        private readonly ILoginBusines _loginBusiness;
        public LoginController(ILoginBusines loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();
            return new ObjectResult(_loginBusiness.FindBYLogin(user));
        }

    }
}
