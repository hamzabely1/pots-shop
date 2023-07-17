using Api.Ioc.Test;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Test.Test.Integration
{

    public class UserControllerIntegration : IClassFixture<WebApplicationFactory<Program>>
    {

        private WebApplicationFactory<Program> _factory;
        private HttpClient _client;


        public UserControllerIntegration(WebApplicationFactory<Program> factory)
        {
            _factory = factory.WithWebHostBuilder(b =>
            b.ConfigureServices(s =>


            {
                s.ConfigureDBContextTest()
                .ConfigureInjectionDependencyRepositoryTest()
                .ConfigureInjectionDependencyServiceTest();

            })
            );
            

            
            
            _client=  factory.CreateClient();
        }

        [Fact]
        public async Task  GetAllUsers ()
        {

        }
    }
}
