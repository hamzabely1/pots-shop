using Api.Data.Context.Model;


namespace Api.Data.Repository.Contract
{
    public interface IRepositoryUser : IGenericRepository<User>
    {

        Task<User> Register(User element);

        Task<User> Login(User element);

        Task<User> GetUserByName(string name);
    }

}
