using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Business.Service.Mapper;
using Api.Data.Entity.Model;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Api.Business.Service.Services
{
    public class ServiceUser : IServiceUser
    {


        private readonly IRepositoryUser _repositoryuser;
        private readonly IRepositoryAddress _repositoryAddress;
        public ServiceUser(IRepositoryUser repositoryUser,IRepositoryAddress repositoryAddress)
        {
            _repositoryuser = repositoryUser;
            _repositoryAddress = repositoryAddress;
        }



        /// <summary>
        /// get user by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<UserRead> GetUserByName(string name)
        {
            User user = await _repositoryuser.GetUserByName(name).ConfigureAwait(false);
            if (user == null)
            {
                return null;
            }
            else 
            {
                var addreesid = user.IdAddress;
                Address address = await _repositoryAddress.GetByKeys(addreesid).ConfigureAwait(false);
                return MapperUser.TransformDtoExitUser(user, address);
            }
        }


        /// <summary>
        /// register
        /// </summary>
        /// <param name="userBase"></param>
        /// <returns></returns>
        public async Task<UserRead> Register(UserRegister userDto)
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
        public async Task<UserRead> Login(UserLogin userDto)
        {
            User newUser = MapperUser.TransformDtoLogin(userDto);
            var users = await _repositoryuser.Login(newUser).ConfigureAwait(false);

            if (users == null)
            {
                return null;
            }
            else
            {
                return MapperUser.TransformDtoExit(users);
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserRead> Update(UserRegister userDto,int id)
        {
            var userUpdate = await _repositoryuser.GetByKeys(id);
            User users = await _repositoryuser.UpdateElementAsync(userUpdate , id);
            return MapperUser.TransformDtoExit(users);
        }


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserRead> Delete(int id)
        {
            var userName = await _repositoryuser.GetByKeys(id);
            User users = await _repositoryuser.DeleteElementAsync(userName);
            return MapperUser.TransformDtoExit(users);
        }

    }
}
