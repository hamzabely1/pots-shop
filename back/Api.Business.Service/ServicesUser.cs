using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Data.Entity2.Model;
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

        /// <summary>
        /// GET  USER
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceGetByUser(string name)
        {
            var users = await _repositoryuser.GetByUser(name).ConfigureAwait(false);

            return Mapper.TransformUserToDTO(users);
        }

        /// <summary>
        /// REGISTER UN USER
        /// </summary>
        /// <param name="userBase"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceRegister(UserRead userDto)
        {
            User newUser = new User()
            {
                LastName = userDto.UserLastName,
                FirstName = userDto.UserFirstName,
                Email = userDto.UserEmail,
                Password = userDto.UserPassword
            };
            var user = await _repositoryuser.Register(newUser).ConfigureAwait(false);
            return Mapper.TransformUserToDTO(user);
        }

        public async Task<UserAdd> ServiceLogin(UserAdd userDto)
        {

          User newUser = new User()
            {
                Email = userDto.UserEmail,
                Password = userDto.UserPassword,
            };
            var users = await _repositoryuser.Login(newUser).ConfigureAwait(false);
            
            return Mapper.TransformUserToDTOAdd(users);
        }

    }
}
