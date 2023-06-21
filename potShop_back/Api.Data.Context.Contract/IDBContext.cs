
using Microsoft.EntityFrameworkCore;

using Api.Data.Context.Model;

namespace Api.Data.Context.Contract
{
    public interface IDBContext : IDB
    {


        DbSet<Item> Items { get; set; }

        DbSet<Basket> Baskets { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<Address> Addresses { get; set; }

        DbSet<AddressUser> AddressUsers { get; set; }   

        DbSet<BasketItem> BasketItems { get; set; }

        DbSet<Color> Colors { get; set; }

        DbSet<Comment> Comments { get; set; }   

        DbSet<Category> Categories { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<OrderItem> OrderItems { get; set; }

        DbSet<Material> Materials { get; set; }

 
       
    }
}
