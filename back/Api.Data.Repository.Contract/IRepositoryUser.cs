using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Entity.Model;


namespace Api.Data.Repository.Contract
{
    public interface IRepositoryUser : IGenericRepository<User>
    {

        Task<User> Register(User element);

        Task<User> Login(User element);

        Task<User> GetUserByName(string name);
    }

}
