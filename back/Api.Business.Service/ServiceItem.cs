using Api.Business.Model.Item;
using Api.Business.Model.User;
using Api.Business.Service.Contract;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service
{
    public class ServiceItem : IServiceItem
    {

        private readonly IRepositoryItem _repositoryitem;
        public ServiceItem(IRepositoryItem repositoryItem)
        {
            _repositoryitem = repositoryItem;
        }
        public async Task<List<ItemRead>> GetListItemAsync()
        {
            var items = await _repositoryitem.GetAllAsync().ConfigureAwait(false);

            List<ItemRead>itemDtos = new();

            foreach (var item in items)
            {
               itemDtos.Add(Mapper.TransformItemToDTO(item));
            }

            return itemDtos;
        }

    }
}
