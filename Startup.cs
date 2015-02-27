using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using MvcSample.Web;

namespace MvcSample
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseErrorPage();
          
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller}/{action}/{id?}",
                  defaults: new { controller = "Home", action = "Index" });
            });

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICervezaRepository, CervezaRepository>();
            services.AddMvc();
        }
    }
}
