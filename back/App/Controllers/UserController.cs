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
            private readonly IServiceUser _serviceUser;
            public UserController(IServiceUser serviceUser)
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
            if( name == null )
            {
                return BadRequest("add name user");
            }
            
            var user = await _serviceUser.GetUserByName(name).ConfigureAwait(false);
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
            UserRead user = await _serviceUser.Register(userDto).ConfigureAwait(false);
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
            var user = await _serviceUser.Login(userDto).ConfigureAwait(false);

            if (user != null)
            {
                return Ok(user) ;
            }
            return BadRequest("Identifiants invalides");




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
            var user = await _serviceUser.Update(userDto, id);
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
            var user = await _serviceUser.Delete(id);
            return Ok(user);
        }

    }
}
