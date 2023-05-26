using Api.Business.Model.Item;
using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Business.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class ItemController : Controller
    {

            private readonly IServiceItem _serviceitem;
            public ItemController(IServiceItem serviceItem)
            {
                _serviceitem = serviceItem;
            }


        /// <summary>
        /// get list item
        /// </summary>
        /// <returns></returns>

            [HttpGet()]
            [ProducesResponseType(typeof(IEnumerable<ItemRead>), 200)]
            [ProducesResponseType(typeof(StatusCodeResult), 500)]
            [ProducesResponseType(typeof(StatusCodeResult), 400)]
            public async Task<ActionResult> Get()
            {
                var item = await _serviceitem.GetListItemAsync().ConfigureAwait(false);

                return Ok(item);
            }


        /// <summary>
        /// update item
        /// </summary>
        /// <param name="itemRead"></param>
        /// <returns></returns>
        [HttpPut("update{id}")]
        [ProducesResponseType(typeof(ItemRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncUpdate(ItemRead itemDto, int id)
        {
            var user = await _serviceitem.ServiceUpdate(itemDto, id);
            return Ok(user);
        }


        /// <summary>
        /// delete item
        /// </summary>
        /// <param name="itemRead"></param>
        /// <returns></returns>
        [HttpDelete("delete{id}")]
        [ProducesResponseType(typeof(ItemRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncDelete(int id)
        {
            var user = await _serviceitem.ServiceDelete(id);
            return Ok(user);
        }

        /// <summary>
        /// add item
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("add")]
        [ProducesResponseType(typeof(ItemRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult<ItemRead>> FuncAdditem(ItemAdd itemDto)
        {
            ItemRead user = await _serviceitem.ServiceAddItem(itemDto).ConfigureAwait(false);
           return Ok(user);
        }

    }
}
