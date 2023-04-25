using Api.Business.Model.Item;
using Api.Business.Model.User;
using Api.Business.Service.Contract;
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

            [HttpGet()]
            [ProducesResponseType(typeof(IEnumerable<ItemRead>), 200)]
            [ProducesResponseType(typeof(StatusCodeResult), 500)]
            [ProducesResponseType(typeof(StatusCodeResult), 400)]
            public async Task<ActionResult> Get()
            {
                var item = await _serviceitem.GetListItemAsync().ConfigureAwait(false);

                return Ok(item);
            }
        
    }
}
