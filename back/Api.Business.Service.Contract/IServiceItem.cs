using Api.Business.Model.Item;
using Api.Business.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Service.Contract
{
    public interface IServiceItem
    {
        Task<List<ItemRead>> GetListItemAsync();

        Task<ItemRead> ServiceUpdate(ItemRead user, int id);

        Task<ItemRead> ServiceDelete(int id);

        Task<ItemRead> ServiceAddItem(ItemAdd item);


    }
}
