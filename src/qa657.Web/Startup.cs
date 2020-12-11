using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace qa657.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<qa657WebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
