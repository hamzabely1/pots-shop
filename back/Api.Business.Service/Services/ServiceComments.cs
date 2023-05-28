using Api.Business.Model.Comments;
using Api.Business.Model.Item;
using Api.Business.Service.Contract;
using Api.Business.Service.Mapper;
using Api.Data.Entity.Model;
using Api.Data.Repository;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Services
{
    public class ServiceComments : IServiceComments
    {

        private readonly IRepositoryComments _repositorycomments;
        public ServiceComments(IRepositoryComments repositoryComments)
        {
            _repositorycomments = repositoryComments;
        }

        /// <summary>
        /// get item by id
        /// </summary>
        /// <returns></returns>
        public async Task<CommentsRead> GetCommentById(int id)
        {
            Comment comment = await _repositorycomments.GetByKeys(id).ConfigureAwait(false);
            return MapperComments.TransformDtoExit(comment);
        }



        /// <summary>
        /// get all comments
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommentsRead>> GetList()
        {
            var comments = await _repositorycomments.GetAllAsync().ConfigureAwait(false);
            List<CommentsRead> commentsDto = new();
            foreach (Comment comment in comments)
            {
                commentsDto.Add(MapperComments.TransformDtoExit(comment));
            }
            return commentsDto;
        }



        //

        /// <summary>
        /// add comments
        /// </summary>
        /// <param name="commentsBase"></param>
        /// <returns></returns>
        public async Task<CommentsRead> AddComments(CommentsAdd commentsDto)
        {
            Comment commentsToAdd = MapperComments.TransformDtoAdd(commentsDto);
            Comment comments = await _repositorycomments.CreateElementAsync(commentsToAdd).ConfigureAwait(false);
            return MapperComments.TransformDtoExit(comments);
        }


    }
}
