using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Data.Repository.Contract;
using Api.Data.Repository;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using Api.Data.Entity.Model;
using Api.Data.Context.Contract;
using Api.Data.Entity;

namespace Api.Test.Test.Unitaire
{
    [TestFixture]
    public class UserTest
    {
        private DbContextOptions<DBContext> _option;
        private IServiceProvider service_provider;
        private IRepositoryUser repository_user;

        [SetUp]
        public void Setup()
        {
            _option = new DbContextOptionsBuilder<DBContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            var services = new ServiceCollection();
            services.AddScoped<IDBContext>(_ => new DBContext(_option));


            
            services.AddScoped<IRepositoryUser, RepositoryUser>();

            service_provider = services.BuildServiceProvider();

            repository_user = service_provider.GetService<IRepositoryUser>();


            //BDD
             var context = service_provider.GetService<DBContext>();
                

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                var user = new User 
                { 
                Id = 1,
                LastName = "hamza" , 
                Email = "hamza@gmail.com",
                FirstName = "Bely",
                Password = "hamza123"
                };
                context.Users.Add(user);
                context.SaveChanges();            
        }

        [TearDown]
        public void TearDown()
        {
             var context = service_provider.GetService<DBContext>();
            context.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetallUser()
        {
            
           
            
        }
    }
}

