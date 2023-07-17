using Api.Business.Model.Item;
using Api.Data.Context.Model;
using Api.Data.Repository.Contract;
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
                Category = item.IdCategory,
                Image = item.Image,
                Color = item.IdColor,
                CreatedDate = item.CreatedDate,
                Material = item.IdMaterial,
                UpdateDate = item.UpdateDate
            };
        }

        public static Item TransformDtoAdd(ItemAdd item)
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
            var colorMap = new Dictionary<int, Material>();
            return new ItemRead()
            {
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Stock = item.Stock,
                Category = item.IdCategory,
                Image = item.Image,
                Color = item.IdColor,
                Material = item.IdMaterial
            };
        }
    }
}
