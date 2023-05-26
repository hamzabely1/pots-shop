using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Azure.Messaging;
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
        /// <summary>
        /// get user by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
            [HttpGet("{name}")]
            [ProducesResponseType(typeof(UserRead), 200)]
            [ProducesResponseType(typeof(StatusCodeResult), 500)]
            [ProducesResponseType(typeof(StatusCodeResult), 400)]
            public async Task<ActionResult> FuncGetUser(string name)
            {
                var user = await _serviceUser.ServiceGetByUser(name).ConfigureAwait(false);
                if(user == null)
                {
                    return BadRequest("l'utlisateur ne exixste pas");
                }
                else
                {
                return Ok(user);
                }
            }

        /// <summary>
        /// register user
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("register")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult<UserRead>> FuncRegister(UserRegister userDto)
        {
            UserRead user = await _serviceUser.ServiceRegister(userDto).ConfigureAwait(false);
            return Ok(user);   
        }

        /// <summary>
        ///login user
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("login")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncLogin(UserLogin userDto)
        {
            var user = await _serviceUser.ServiceLogin(userDto).ConfigureAwait(false);       
            return Ok(user);
        }

        /// <summary>
        /// update user
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPut("update{id}")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncUpdate(UserRegister userDto,int id)
        {
            var user = await _serviceUser.ServiceUpdate(userDto, id);
            return Ok(user);
        }


        /// <summary>
        /// delete user
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpDelete("delete{id}")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncDelete(int id)
        {
            var user = await _serviceUser.ServiceDelete(id);
            return Ok(user);
        }

    }
}
