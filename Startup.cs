using System.IO;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Data;
using EPiServer.Web.Routing;
using Mediachase.Commerce.Anonymous;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace epi12
{
    public class Startup
    {
        private readonly IWebHostEnvironment _webHostingEnvironment;
        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment webHostingEnvironment, IConfiguration configuration)
        {
            _webHostingEnvironment = webHostingEnvironment;
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionStringCommerce = _configuration.GetConnectionString("EcfSqlConnection");

            services.Configure<DataAccessOptions>(o =>
            {
                o.ConnectionStrings.Add(new ConnectionStringOptions
                {
                    ConnectionString = connectionStringCommerce,
                    Name = "EcfSqlConnection"
                });
            });

            services.AddCmsAspNetIdentity<ApplicationUser>(o =>
            {
                if (string.IsNullOrEmpty(o.ConnectionStringOptions?.ConnectionString))
                {
                    o.ConnectionStringOptions = new ConnectionStringOptions()
                    {
                        Name = "EcfSqlConnection",
                        ConnectionString = connectionStringCommerce
                    };
                }
            });

            if (_webHostingEnvironment.IsDevelopment())
            {
                //Add development configuration
            }

            services.AddMvc();
            services.AddCommerce();
            services.AddEmbeddedLocalization<Startup>();
            //services.AddCms()
            //    .AddCmsAspNetIdentity<ApplicationUser>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/util/Login";
            });

            services.AddContentDefinitionsApi();
            services.AddContentDeliveryApi().WithSiteBasedCors().WithFriendlyUrl();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAnonymousId();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "Assets")),
                RequestPath = "/Assets"
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "Default", pattern: "{controller}/{action}/{id?}");
                endpoints.MapContent();
            });
        }
    }
}
