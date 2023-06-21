using Api.Business.Model.Comments;
using Api.Data.Context.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Mapper
{
    public class MapperComments
    {
        public static CommentsRead TransformDtoExit(Comment comment)
        {
            return new CommentsRead()
            {
             Id = comment.Id,
             IdItem= comment.IdItem,
             Content= comment.Content,
             IdUser= comment.IdUser,
             CreatedDate= comment.CreatedDate,
            };
        }

        public static Comment TransformDtoAdd(CommentsAdd comment)
        {
            return new Comment()
            {
                IdItem = comment.IdItem,
                Content = comment.Content,
                IdUser = comment.IdUser,
                CreatedDate = comment.CreatedDate,
            };
        }
    }
}
