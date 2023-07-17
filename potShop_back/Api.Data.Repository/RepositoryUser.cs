using Api.Data.Repository.Contract;
using Api.Data.Context.Contract;
using Microsoft.EntityFrameworkCore;

using Api.Data.Context.Model;
using System.Security.Cryptography;

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
        /// get by name
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<User> GetUserByName(string name)
        {
           User user = await _idbcontext.Users.FirstOrDefaultAsync(x => x.FirstName == name ).ConfigureAwait(false);
           return user;
        }


        /// <summary>
        /// Rregister user
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

           
            var user = await _idbcontext.Users.FirstOrDefaultAsync(x =>  x.Email == element.Email).ConfigureAwait(false);


            if (user != null && user.Password == element.Password)
            {
                return user;
            }
            return null;
        }


   


    }
}
