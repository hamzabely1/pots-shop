using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class UserController : Controller

        {
            private readonly IServicesUser _serviceUser;
            public UserController(IServicesUser serviceUser)
            {
                _serviceUser = serviceUser;
            }

            [HttpGet()]
            [ProducesResponseType(typeof(IEnumerable<UserRead>), 200)]
            [ProducesResponseType(typeof(StatusCodeResult), 500)]
            [ProducesResponseType(typeof(StatusCodeResult), 400)]
            public async Task<ActionResult> Get()
            {
                var user = await _serviceUser.GetListUserAsync().ConfigureAwait(false);

                return Ok(user);
            }
        }
}
