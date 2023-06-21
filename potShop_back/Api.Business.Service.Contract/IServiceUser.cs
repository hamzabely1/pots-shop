using Api.Business.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Contract
{
    public interface IServiceUser 
    {

        Task<UserRead> Login(UserLogin user);

        Task<UserRead> GetUserByName(string name);

        Task<UserRead> Register(UserRegister user);

        Task<UserRead> Update(UserRegister user,int id);

        Task<UserRead> Delete(int id);
    }
}
