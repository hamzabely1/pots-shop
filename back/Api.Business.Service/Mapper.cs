using Api.Business.Model.User;
using Api.Data.Entity2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service
{
    public class Mapper
    {

        public static UserRead TransformUserToDTO(User user)
        {
            UserRead userRead = new UserRead()
            {
                UserLastName = user.LastName,
                UserFirstName = user.FirstName,
                UserEmail = user.Email,
                UserPassword = user.Password

            };

            return userRead;

        }
    }
}
