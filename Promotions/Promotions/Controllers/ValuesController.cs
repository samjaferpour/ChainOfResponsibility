using Microsoft.AspNetCore.Mvc;
using Promotions.Services;

namespace Promotions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly RegularUserHandler _regularUserHandler;

        public ValuesController(RegularUserHandler regularUserHandler)
        {
            this._regularUserHandler = regularUserHandler;
        }
        [HttpPost]
        public IActionResult Order(string userType, decimal price)
        {
            //var regularUser = new RegularUserHandler();
            _regularUserHandler.SetNextHandler(new VipUserHandler())
                       .SetNextHandler(new NewUserHandler())
                       .SetNextHandler(new NoneUserHandler());

            var response = _regularUserHandler.CalculateDiscount(userType, price);
            return Ok(response);
        }
    }
}
