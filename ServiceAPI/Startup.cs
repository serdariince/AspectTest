using Businnes.Abstract;
using Businnes.Contrete;
using DataAccess.Abstrast;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace ServiceAPI
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
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            );

            services.AddSingleton<ITesisServices, TesisManager>();
            services.AddSingleton<ITesisDal, EfTesisDal>();
            services.AddSingleton<IKameraServices, KameraManager>();
            services.AddSingleton<IKameraDal, EfKameraDal>();
            services.AddSingleton<IKayitProgramiServices, KayitProgramiManager>();
            services.AddSingleton<IKayitProgramiDal, EfKayitProgramiDal>();

            services.AddSingleton<IIpService, IpManager>();
            services.AddSingleton<IIpDal, EfIpDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}