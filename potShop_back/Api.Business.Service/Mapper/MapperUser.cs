using Api.Business.Model.User;
using Api.Business.Service.Authorize;
using Api.Data.Context.Model;


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
                FirstName = user.FirstName,

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

        public static UserRead TransformDtoExitToken(User user, string token)
        {
            if (user == null)
            {
                return null;
            }
            return new UserRead()
            {
                Email = user.Email,
                Password = user.Password,
                Token = token,
              
            };
        }


        public static UserRead TransformDtoExit(User user)
        {
            return new UserRead()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };
        }


        public static UserRead TransformDtoExitUser(User user)
        {

            return new UserRead()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };

        }
    }



}
