using Microsoft.AspNetCore.Mvc;
using Promotions.Services;

namespace Promotions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Order(string userType, decimal price)
        {
            var regularUser = new RegularUserHandler();
            regularUser.SetNextHandler(new VipUserHandler())
                       .SetNextHandler(new NewUserHandler());

            var response = regularUser.CalculateDiscount(userType, price);
            return Ok(response);
        }
    }
}
