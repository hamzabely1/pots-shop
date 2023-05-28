using Api.Business.Model.User;
using Api.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Api.Business.Service.Authorize;

namespace Api.Business.Service.Mapper
{
    public class MapperUser
    {

       
        public static User TransformDtoRegister(UserRegister user)
        {
          
            if (user == null)
               {
                   return null;
               }
            return new User()
            {
                Email = user.Email,
                Password = PasswordEncryptor.EncryptPassword(user.Password),
                LastName = user.LastName,
                FirstName = user.FirstName
            };
        }

        public static User TransformDtoLogin(UserLogin user)
        {
              if(user == null)
               {
                   return null;
               }
            return new User()
            {
                Email = user.Email,
                Password = user.Password,
            };
        }


        public static UserRead TransformDtoExit(User user)
        {
            return new UserRead()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }


        public static UserRead TransformDtoExitUser(User user, Address address)
        {
            Address address1 = address;

            return new UserRead()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = MapperAddress.TransformDtoExit(address)
            };

        }
    }



}
