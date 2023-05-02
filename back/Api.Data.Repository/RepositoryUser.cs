using Api.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Entity2.Model;
using Api.Data.Context.Contract;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System.Reflection.Metadata;

namespace Api.Data.Repository
{
    public class RepositoryUser : GenericRepository<User>, IRepositoryUser
    {

        public RepositoryUser(IDBContext _idbcontext) : base(_idbcontext)
        {

            _table = _idbcontext.Set<User>();
        }

        public readonly DbSet<User> _table;


        /// <summary>
        /// GET BY USER
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<User> GetByUser(string name)
        {
            return await _idbcontext.Users.FirstOrDefaultAsync(x => x.FirstName == name).ConfigureAwait(false);
        }

        /// <summary>
        /// REGISTER
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<User> Register(User element)
        {
            var elementAdded = await _table.AddAsync(element).ConfigureAwait(false);
            await _idbcontext.SaveChangesAsync().ConfigureAwait(false);

            return elementAdded.Entity;

        }



        /// <summary>
        /// LOGIN
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<User> Login(User element)
        {
            await _idbcontext.SaveChangesAsync().ConfigureAwait(false);
        var verifi = await _idbcontext.Users.FirstOrDefaultAsync(x => x.Email == element.Email && x.Password == element.Password).ConfigureAwait(false);

            return verifi;

        }
    }
}
