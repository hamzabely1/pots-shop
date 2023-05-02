using Api.Business.Model.Item;
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
            if(user == null)
            {
                return null;
            }
            UserRead userRead = new UserRead()
            {
                UserLastName = user.LastName,
                UserFirstName = user.FirstName,
                UserEmail = user.Email,
                UserPassword = user.Password

            };
           
            return userRead;
        }

        public static UserAdd TransformUserToDTOAdd(User user)
        {
            if (user == null)
            {
                return null;
            }
            UserAdd userAdd = new UserAdd()
            {
                UserEmail = user.Email,
                UserPassword = user.Password

            };

            return userAdd;
        }
        public static ItemRead TransformItemToDTO(Item item)
        {
            ItemRead itemRead = new ItemRead()
            {
           ItemName = item.Name,
           ItemDescription = item.Description,
           ItemPrice = item.Price,
           ItemStock = item.Stock,
           ItemType = item.Type,
           ItemImage= item.Image

            };

            return itemRead;

        }
    }
}
