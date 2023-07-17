using Api.Business.Model.Comments;
using Api.Business.Model.Item;
using Api.Business.Service.Contract;
using Api.Business.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : Controller
    {


        private readonly IServiceComments _servicecomments;
        public CommentsController(IServiceComments serviceComments)
        {
            _servicecomments = serviceComments;
        }


        /// <summary>
        /// get list comments
        /// </summary>
        /// <returns></returns>

        [HttpGet()]
        [ProducesResponseType(typeof(IEnumerable<CommentsRead>), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult> FuncGetList()
        {
            var comments = await _servicecomments.GetList().ConfigureAwait(false);

            return Ok(comments);
        }

        /// <summary>
        /// add item
        /// </summary>
        /// <param name="userRead"></param>
        /// <returns></returns>
        [HttpPost("add")]
        [ProducesResponseType(typeof(CommentsRead), 200)]
        [ProducesResponseType(typeof(StatusCodeResult), 500)]
        [ProducesResponseType(typeof(StatusCodeResult), 400)]
        public async Task<ActionResult<CommentsRead>> FuncAddComments(CommentsAdd commentsDto)
        {
            CommentsRead comments = await _servicecomments.AddComments(commentsDto).ConfigureAwait(false);
            return Ok(comments);
        }



    }
}
