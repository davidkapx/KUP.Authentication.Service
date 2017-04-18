using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using KUP.Authentication.Data.Models;
using KUP.Authentication.Data.Repositories.Implementation;
using KUP.Authentication.Data.Repositories.Definition;
using KUP.Authentication.Business.Components.Definition;
using KUP.Authentication.Business.Components.Implementation;
using Microsoft.Extensions.PlatformAbstractions;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Diagnostics;
using KUP.Authentication.Api.Models;
using Microsoft.EntityFrameworkCore;
using KUP.Framework.Common.Security.JwtToken;
using KUP.Framework.Common.Configuration;

namespace KUP.Authentication.Api
{
    public class Startup
    {
        private string appName;
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            appName = Configuration["AppSettings:AppName"];
        }

        public IContainer ApplicationContainer { get; private set; }
        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", corsBuilder => corsBuilder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            // Add framework services.
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddMemoryCache();
            services.AddCors();
            services.AddMvc();
            services.AddDbContext<UniversityPortal_KVUContext>(options => options.UseSqlServer(GetConnectionString()));
            services.AddSwaggerGen();

            services.ConfigureSwaggerGen(options =>
            {
                options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "KUP Authentication Service",
                    Description = "Kaplan University Portal Authentication Service",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Ralph Blaise", Email = "rblaise@kaplan.edu", Url = "http://twitter.com/topdawgevh" },
                    License = new License { Name = "Use under LICX", Url = "http://url.com" }
                });

                //Determine base path for the application.
                //var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //var xmlPath = GetXmlCommentsPath();
                //Set the comments path for the swagger json and ui.
                //options.IncludeXmlComments(xmlPath);
            });

            var builder = new ContainerBuilder();
            builder.RegisterType<PortalUserRepository>().As<IPortalUserRepository>();
            builder.RegisterType<JWTSettingComponent>().As<IJWTSettingComponent>();
            builder.RegisterType<JwtTokenComponent>().As<IJwtTokenComponent>().InstancePerLifetimeScope();
            builder.RegisterType<AuthenticationComponent>().As<IAuthenticationComponent>();

            builder.Populate(services);
            this.ApplicationContainer = builder.Build();

            // Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(this.ApplicationContainer);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IApplicationLifetime appLifetime)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUi();
            app.UseCors("CorsPolicy");

            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 500; // or another Status accordingly to Exception Type
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        var ex = error.Error;

                        await context.Response.WriteAsync(new ErrorDto()
                        {
                            Code = 500,
                            Message = ex.Message // or your custom message
                            // other custom data
                        }.ToString(), Encoding.UTF8);
                    }
                });
            });


            app.UseMvc();

            appLifetime.ApplicationStopped.Register(() => this.ApplicationContainer.Dispose());
        }

        #region "helpers"
        private string GetXmlCommentsPath()
        {
            var app = PlatformServices.Default.Application;
            return System.IO.Path.Combine(app.ApplicationBasePath, "KUP.Authentication.Api.xml");
        }

        private string GetConnectionString()
        {
            var appSettings = new AppSettings(appName);
            var connString = appSettings.GetSetting("UniversityPortal_KVU_ConnectionString");
            var connPassword = appSettings.GetDecryptedSetting("UniversityPortal_KVU_ConnPassword");
            connString = connString.Replace("Password=[]", "Password=" + connPassword);
            return connString;
        }

        #endregion
    }
}
