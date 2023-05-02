﻿using Api.Business.Model.User;
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
        /// GET BY USER
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
        /// REGISTER USER
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("register")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncRegister(UserRead userRead)
        {
            var user = await _serviceUser.ServiceRegister(userRead).ConfigureAwait(false);
            return Ok(user);   
        }

        /// <summary>
        /// LOGIN USER
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("login")]
        [ProducesResponseType(typeof(UserRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncLogin(UserAdd userAdd)
        {
            
            var user = await _serviceUser.ServiceLogin(userAdd).ConfigureAwait(false);
           if(user.UserEmail == null  )
            {
                return BadRequest("email recuire");
            }
                 else if (user.UserPassword == null)
            {
                return BadRequest("password rexuire");
            }
                else if (user.UserEmail != "" && user.UserPassword != "") { }
            {
                return Ok("login passe");
            }
          
            
        }
    }
}
