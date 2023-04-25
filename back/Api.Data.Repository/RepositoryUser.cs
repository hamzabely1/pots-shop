using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Entity2.Model;
using Api.Data.Context.Contract;

namespace Api.Data.Repository
{
    public class RepositoryUser : GenericRepository<User>,IRepositoryUser
    {
        public RepositoryUser(IDBContext _idbcontext) : base(_idbcontext)
        {
        }
    }
}
