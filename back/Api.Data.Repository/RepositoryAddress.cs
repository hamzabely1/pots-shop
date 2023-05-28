using Api.Data.Context.Contract;
using Api.Data.Entity.Model;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Repository
{
    public class RepositoryAddress : GenericRepository<Address>, IRepositoryAddress
    {
        public RepositoryAddress(IDBContext _idbcontext) : base(_idbcontext)
        {
        }
        private readonly DbSet<Address> _table;

    }
}
