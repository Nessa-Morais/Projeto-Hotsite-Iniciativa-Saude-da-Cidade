using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging; // chama a biblioteca Logging  

namespace Hotsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory logFac ) /* foi adicionado mei um parametro
                                                                                                          ILoggerFactory logfac para possibilirar
                                                                                                          o chamado da classe Logger dentro do metodo
                                                                                                          configure de startup, é por esse motivo sera possivel
                                                                                                           que sera possivel instanciar a classe 
                                                                                                           ILoggerFactory em outros ambientes , 
                                                                                                           como models e controlers etc*/
        { 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            

            logFac.AddFile("Logs/log-{Date}.txt",LogLevel.Trace); // define o nivel do level do loog , e cria a pasta onde vai ser salvo o 
                                                                    // arquivo de log, no nosso caso em Logs ou "Logs/log-{Date}.txt"
        }
    }
}
