using Api.Business.Model.Item;
using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Business.Service.Mapper;
using Api.Data.Entity.Model;
using Api.Data.Repository;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Services
{
    public class ServiceItem : IServiceItem
    {

        private readonly IRepositoryItem _repositoryitem;
        public ServiceItem(IRepositoryItem repositoryItem)
        {
            _repositoryitem = repositoryItem;
        }
        /// <summary>
        /// list item
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemRead>> GetListItemAsync()
        {
            var items = await _repositoryitem.GetAllAsync().ConfigureAwait(false);

            List<ItemRead> itemDtos = new();

            foreach (var item in items)
            {
                itemDtos.Add(MapperItem.TransformItemToDTO(item));
            }

            return itemDtos;
        }

        /// <summary>
        /// add item
        /// </summary>
        /// <param name="itemBase"></param>
        /// <returns></returns>
        public async Task<ItemRead> ServiceAddItem(ItemAdd itemDto)
        {
            Item itemToAdd = MapperItem.TransformItemAdd(itemDto);
            Item item = await _repositoryitem.CreateElementAsync(itemToAdd).ConfigureAwait(false);
            return MapperItem.TransformDtoExit(item);
        }


        /// <summary>
        /// Update
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<ItemRead> ServiceUpdate(ItemRead itemDto, int id)
        {
            var itemUpdate = await _repositoryitem.GetByObjectByKeys(id);
            Item item = await _repositoryitem.UpdateElementAsync(itemUpdate, id);

            return MapperItem.TransformDtoExit(item);
        }


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<ItemRead> ServiceDelete(int id)
        {
            var itemId = await _repositoryitem.GetByObjectByKeys(id);
            Item item = await _repositoryitem.DeleteElementAsync(itemId);

            return MapperItem.TransformDtoExit(item);
        }

    }
}
