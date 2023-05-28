using Api.Business.Model.Item;
using Api.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Mapper
{
    public class MapperAddress
    {
        public static Address TransformDtoExit(Address address)
        {
            return new Address()
            {
                City = address.City,
                State = address.State,
                Code= address.Code,
                Street= address.Street,
            };
        }
    }
}
