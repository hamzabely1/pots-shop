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

        Task<UserAdd> ServiceLogin(UserAdd user);
        Task<UserRead> ServiceGetByUser(string name);

        Task<UserRead> ServiceRegister(UserRead user);
    }
}
