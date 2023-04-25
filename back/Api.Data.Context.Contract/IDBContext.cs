
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Entity2.Model;

namespace Api.Data.Context.Contract
{
    public interface IDBContext : IDB
    {


        DbSet<Item> Items { get; set; }

        DbSet<Panier> Paniers { get; set; }

        DbSet<User> Users { get; set; }
    }
}
