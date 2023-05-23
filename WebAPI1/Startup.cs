using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1
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
            //Bunlar AOP: Bir metodun önünde sonunda hata verdiðinde çalýþýr saðlýyor
            //Autofac, Ninject, CastleWindsor, StructureMap, LightInject, DryInject --> IoC Container :
            //Bunlar .nette AddSingleton iþi yapýyor
            //AOP
            //Postsharp
            //[LogAspect]
            //[Validate]
            //[Cache]
            //[RemoveCache]
            //[Transaction]
            //[Performance]
            services.AddControllers();
            //contructorda IProductService gördüðünde product manager koy diyoruz. Ama product manager içinde veri/data olmayacak
            //services.AddSingleton<IProductService, ProductManager>();
            //services.AddSingleton<IProductDal, EfProductDal>();
            //Autofac kullanmak için business - manage nuget packages autofac
            // interfaceler referans tutucudu. Businesse dependencyresolvers klasörü ve autofac klasörü açýyoruz.
            //Autofac bize AOPe desteði saðlýyor
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
