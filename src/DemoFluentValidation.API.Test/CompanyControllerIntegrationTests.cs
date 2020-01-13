using DemoFluentValidation.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoFluentValidation.API.Test
{
    public class CompanyControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public CompanyControllerIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Add()
        {
            var httpResponse = await _client.PostAsync("/api/company", new StringContent(JsonConvert.SerializeObject(new Company() { Name = "rodrigo" }), Encoding.UTF8, "application/json"));

            httpResponse.EnsureSuccessStatusCode();
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            //var players = JsonConvert.DeserializeObject<IEnumerable<Player>>(stringResponse);
            //Assert.Contains(players, p => p.FirstName == "Wayne");
            //Assert.Contains(players, p => p.FirstName == "Mario");
        }
    }
}
