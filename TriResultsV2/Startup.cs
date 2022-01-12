using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriResultsV2
{
    public class Startup
    {
        private readonly IWebHostEnvironment Environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            Environment = webHostEnvironment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();

            bool localData = bool.Parse(Configuration["Data.Local"]);

            if (localData)
            {
                // Add local services.
                services.AddTransient<Services.Interfaces.ISwimService, Services.Local.LocalSwimService>();
                services.AddTransient<Services.Interfaces.IBikeService, Services.Local.LocalBikeService>();
                services.AddTransient<Services.Interfaces.IRunService, Services.Local.LocalRunService>();
                services.AddTransient<Services.Interfaces.ITriathlonService, Services.Local.LocalTriathlonService>();
                services.AddTransient<Services.Interfaces.IDuathlonService, Services.Local.LocalDuathlonService>();
                services.AddTransient<Services.Interfaces.IDiaryService, Services.Local.LocalDiaryService>();
            }
            else
            {
                // Add SQL services.
                services.AddTransient<Services.Interfaces.ISwimService, Services.Sql.SqlSwimService>();
                services.AddTransient<Services.Interfaces.IBikeService, Services.Sql.SqlBikeService>();
                services.AddTransient<Services.Interfaces.IRunService, Services.Sql.SqlRunService>();
                services.AddTransient<Services.Interfaces.ITriathlonService, Services.Sql.SqlTriathlonService>();
                services.AddTransient<Services.Interfaces.IDuathlonService, Services.Sql.SqlDuathlonService>();
                services.AddTransient<Services.Interfaces.IDiaryService, Services.Sql.SqlDiaryService>();
            }

            // Use WebOptimizer to minify the JS files (if not development environment).
            // https://github.com/ligershark/WebOptimizer
            if (Environment.IsDevelopment())
            {
                services.AddWebOptimizer(minifyJavaScript: false, minifyCss: false);
            }
            else
            {
                services.AddWebOptimizer(pipeline =>
                {
                    pipeline.MinifyJsFiles("js/site.js");
                });
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // WebOptimizer - for minifying and bundling files.
            // https://github.com/ligershark/WebOptimizer
            app.UseWebOptimizer();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
