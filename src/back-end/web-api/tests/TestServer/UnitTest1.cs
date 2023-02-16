using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace TestServer
{
    public class UnitTest1
    {
        [Fact]
        public async void MiddlewareTest_ReturnsNotFoundForRequest()
        {
            using var host = await new HostBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseTestServer()
                        .ConfigureServices(services =>
                        {
                            //services.Coun
                        })
                        .Configure(app =>
                        {
                            //app.UseMiddleware();
                        });
                }).StartAsync();

            var response = await host.GetTestClient().GetAsync("/");

            Assert.NotEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}