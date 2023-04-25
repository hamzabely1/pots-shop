using Api.Data.Context.Contract;
using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Entity2.Model;

namespace Api.Data.Repository
{
    public class RepositoryPanier : GenericRepository<Panier>, IRepositoryPanier
    {
        public RepositoryPanier(IDBContext _idbcontext) : base(_idbcontext)
        { 
        }
    }
}
