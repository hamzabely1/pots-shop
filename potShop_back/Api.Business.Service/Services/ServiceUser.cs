using Api.Business.Model.User;
using Api.Business.Service.Authorize;
using Api.Business.Service.Contract;
using Api.Business.Service.Mapper;
using Api.Data.Context.Model;

using Api.Data.Repository.Contract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Business.Service.Services
{
    public class ServiceUser : IServiceUser
    {


        private readonly IRepositoryUser _repositoryuser;
        private readonly IRepositoryAddress _repositoryAddress;
        private object _idbcontext;
        private AppSettings appSettings;

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
                throw new ArgumentException($"le user {name} ne existe pas.");
            }
            else 
            {
                return MapperUser.TransformDtoExitUser(user);
            }
        }


        /// <summary>
        /// register
        /// </summary>
        /// <param name="userBase"></param>
        /// <returns></returns>
        public async Task<UserRead> Register(UserRegister userDto)
        {
            var userByEmail = await _repositoryuser.GetUserByName(userDto.Email);

            if (userByEmail is not null)
            {
                throw new ArgumentException($"l'email existe {userDto.Email} déjà.");
            }

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
            User user = await _repositoryuser.Login(newUser).ConfigureAwait(false);

            if (user == null)
            {
                throw new ArgumentException("Username or password is incorrects" );
            }
            Token token = new Token(appSettings); 
            string jwtToken = token.GenerateJwtToken(user);
            return MapperUser.TransformDtoExitToken(user, jwtToken);
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
