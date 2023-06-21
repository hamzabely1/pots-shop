using Api.Data.Context.Contract;
using Api.Data.Context.Model;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;


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
