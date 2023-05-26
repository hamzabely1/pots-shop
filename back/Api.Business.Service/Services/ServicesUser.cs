using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Business.Service.Mapper;
using Api.Data.Entity.Model;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Api.Business.Service.Services
{
    public class ServicesUser : IServicesUser
    {

        private readonly IRepositoryUser _repositoryuser;
        public ServicesUser(IRepositoryUser repositoryUser)
        {
            _repositoryuser = repositoryUser;
            
        }

        /// <summary>
        /// get user by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceGetByUser(string name)
        {
            User users = await _repositoryuser.GetByKeyAsync(name).ConfigureAwait(false);

            return MapperUser.TransformDtoExit(users);
        }

        /// <summary>
        /// register
        /// </summary>
        /// <param name="userBase"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceRegister(UserRegister userDto)
        {
            User userToRegister = MapperUser.TransformDtoRegister(userDto);
            User user = await _repositoryuser.Register(userToRegister).ConfigureAwait(false);
            return MapperUser.TransformDtoExit(user);
        }


        /// <summary>
        /// Login
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceLogin(UserLogin userDto)
        {

            User newUser = MapperUser.TransformDtoLogin(userDto);
            var users = await _repositoryuser.Login(newUser).ConfigureAwait(false);

            return MapperUser.TransformDtoExit(users);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceUpdate(UserRegister userDto,int id)
        {
            var userUpdate = await _repositoryuser.GetByObjectByKeys(id);
            User users = await _repositoryuser.UpdateElementAsync(userUpdate , id);

            return MapperUser.TransformDtoExit(users);
        }


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserRead> ServiceDelete(int id)
        {
            var userName = await _repositoryuser.GetByObjectByKeys(id);
            User users = await _repositoryuser.DeleteElementAsync(userName);
            return MapperUser.TransformDtoExit(users);
        }

    }
}
