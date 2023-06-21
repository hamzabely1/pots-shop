using Api.Business.Model.Comments;
using Api.Business.Model.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Contract
{
    public interface IServiceComments 
    {

        Task<List<CommentsRead>> GetList();

        Task<CommentsRead> GetCommentById(int id);
        Task<CommentsRead> AddComments(CommentsAdd comments);

    }
}
