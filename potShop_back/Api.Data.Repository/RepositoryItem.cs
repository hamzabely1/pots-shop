using Api.Data.Context.Contract;
using Api.Data.Context.Model;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class RepositoryItem : GenericRepository<Item>,IRepositoryItem
    {
        public RepositoryItem(IDBContext _idbcontext) : base(_idbcontext)
        {
        }
        private readonly DbSet<Item> _table;

       
    }
}
