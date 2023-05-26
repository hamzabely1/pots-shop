using Api.Business.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Contract
{
    public interface IServicesUser
    {

        Task<UserRead> ServiceLogin(UserLogin user);

        Task<UserRead> ServiceGetByUser(string name);

        Task<UserRead> ServiceRegister(UserRegister user);

        Task<UserRead> ServiceUpdate(UserRegister user,int id);

        Task<UserRead> ServiceDelete(int id);
    }
}
