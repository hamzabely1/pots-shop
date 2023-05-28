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
        Task<List<ItemRead>> GetList();

        Task<ItemRead> GetItemById(int id);

        Task<ItemRead> Update(ItemRead user, int id);

        Task<ItemRead> Delete(int id);

        Task<ItemRead> AddItem(ItemAdd item);
    }
}
