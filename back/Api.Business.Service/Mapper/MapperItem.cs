using Api.Business.Model.Item;
using Api.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Mapper
{
    public class MapperItem
    {
        public static ItemRead TransformItemToDTO(Item item)
        {
            return  new ItemRead()
            {
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Stock = item.Stock,
                IdCategory = item.IdCategory,
                Image = item.Image,
                IdColor = item.IdColor,
                CreatedDate = item.CreatedDate,
                IdMaterial = item.IdMaterial,
                UpdateDate = item.UpdateDate
            };
        }

        public static Item TransformItemAdd(ItemAdd item)
        {
            return new Item()
            {
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Stock = item.Stock,
                IdCategory = item.IdCategory,
                Image = item.Image,
                IdColor = item.IdColor,
                CreatedDate = item.CreatedDate,
                IdMaterial = item.IdMaterial,
                UpdateDate = item.UpdateDate
            };
        }

        public static ItemRead TransformDtoExit(Item item)
        {
            return  new ItemRead()
            {
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Stock = item.Stock,
                IdCategory = item.IdCategory,
                Image = item.Image,
                IdColor = item.IdColor,
                IdMaterial = item.IdMaterial,
            };
        }
    }
}