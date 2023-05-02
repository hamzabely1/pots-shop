using Api.Data.Context.Contract;
using Api.Data.Entity2.Model;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
