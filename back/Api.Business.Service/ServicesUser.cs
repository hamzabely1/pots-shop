using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service
{
    public class ServicesUser : IServicesUser
    {

        private readonly IRepositoryUser _repositoryuser;
        public ServicesUser(IRepositoryUser repositoryUser)
        {
            _repositoryuser = repositoryUser;
        }
        public async Task<List<UserRead>> GetListUserAsync()
        {
            var users = await _repositoryuser.GetAllAsync().ConfigureAwait(false);

            List<UserRead> userDtos = new();

            foreach (var user in users)
            {
                userDtos.Add(Mapper.TransformUserToDTO(user));
            }

            return userDtos;
        }
    }
}
