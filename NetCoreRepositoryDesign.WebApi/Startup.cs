using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetCoreRepositoryDesign.Business.Abstract;
using NetCoreRepositoryDesign.Business.Concrete;
using NetCoreRepositoryDesign.DataAccess;
using NetCoreRepositoryDesign.DataAccess.Repositories.Abstract;
using NetCoreRepositoryDesign.DataAccess.Repositories.Concrete;

namespace NetCoreRepositoryDesign.WebApi
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
            var connectionString = Configuration.GetConnectionString("NcrdDbConnectionManas");
            services.AddDbContext<NcrdContext>(options => options.UseSqlServer(connectionString));

            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IPersonnelRepository, PersonnelRepository>();
            //services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPersonnelService, PersonnelService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseMvcWithDefaultRoute();
        }
    }
}
