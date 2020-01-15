using AutoMapper;
using EventSchedule.Application;
using EventSchedule.Application.Interfaces;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Core.Interfaces.Services;
using EventSchedule.Core.Interfaces.UnitOfWork;
using EventSchedule.Core.Services;
using EventSchedule.Infraestructure.Data.Context;
using EventSchedule.Infraestructure.Data.Repositories;
using EventSchedule.Infraestructure.Data.UnitOfWork;
using EventSchedule.UserInterface.API.Rest.Event;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace EventSchedule.UserInterface.API.Rest
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new Info
                {
                    Title = "ClientSchedule Rest API",
                    Version = "v1",
                    Description = "Swagger Rest API for ClientSchedule Project",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Daniel Lucena",
                        Email = "daniellucenag@gmail.com",
                        Url = "https://twitter.com/daniellucena"
                    }
                });
            });

            //Map for MVVM
            services.AddAutoMapper(typeof(EventProfile));

            //Dependency injection of the services, repository and application
            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddScoped(typeof(IEventAppService), typeof(EventAppService));

            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped(typeof(IEventService), typeof(EventService));

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IEventRepository), typeof(EventRepository));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EventScheduleContext>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("../swagger/v1/swagger.json", "EventSchedule Rest API"); });
        }
    }
}