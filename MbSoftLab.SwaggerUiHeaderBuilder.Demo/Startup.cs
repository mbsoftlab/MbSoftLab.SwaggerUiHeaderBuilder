using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbSoftLab.SwaggerUiHeaderBuilder.Demo
{
    public class Startup
    {
        private ISwaggerUiCustomHeaderConfig _swaggerUiCustomHeaderConfig;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _swaggerUiCustomHeaderConfig = new YourJsonSwaggerUiCustomHeaderConfig(configuration);

            //Using default implementation für SwaggerUiCustomHeaderConfig
            //_swaggerUiCustomHeaderConfig=new SwaggerUiCustomHeaderConfig()
            //{ 
            //    Titel= "MyTestTitel",
            //    Version= "v1.0.0.1",
            //    HeaderBgColor= "#fff9f3",
            //    HeaderFontColor= "black",
            //    HoverColor= "#d66b00"
            //};
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MbSoftLab.SwaggerUiHeaderBuilder.Demo", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApi V1");
                
                    // Example 1
                    //c.HeadContent = new SwaggerUiHeaderBuilder()
                    //               .ForTitel("MyTestTitel")
                    //               .ForVersion("v1.0.0.1")
                    //               .AddCustomLink("MyCustomLink1", new Uri("https://myCutom1.url"))
                    //               .AddCustomLink("MyCustomLink2", new Uri("https://myCutom2.url"))
                    //               .ForHeaderBgColor("#fff9f3")
                    //               .ForHoverBgColor("#d66b00")
                    //               .ForHeaderFontColor("black")
                    //               .Build();


                    //Example 2
                    //c.UseCustomHeader(header => header
                    //                      .ForTitel("MyTestTitel")
                    //                      .ForVersion("v1.0.0.1")
                    //                      .AddCustomLink("MyCustomLink1", new Uri("https://myCutom1.url"))
                    //                      .AddCustomLink("MyCustomLink2", new Uri("https://myCutom2.url"))
                    //                      .ForHeaderBgColor("#fff9f3")
                    //                      .ForHoverBgColor("#d66b00")
                    //                      .ForHeaderFontColor("black"));

                    //Example 3
                    c.UseCustomHeader(header => header.UseConfig(_swaggerUiCustomHeaderConfig));



                });
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
