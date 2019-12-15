using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Domain.Models;
using TodoList.Domain.Repository;
using TodoList.Extensibility.Repository;
using TodoList.Extensibility.Services;
using TodoList.Extensibility.Validators;
using TodoList.Services.Services;
using TodoList.Services.Validators;
using TodoList.WebApi.Mappings;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace TodoList.WebApi
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
            var connectionString = Configuration["connectionStrings:onlineElectionDBConnectionString"];
            services.AddDbContext<TodoListContext>(o => o.UseSqlServer(connectionString));
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new TodoMappingProfile()); });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<INoteValidator, NoteValidator>();
            services.AddScoped<ICategoryValidator, CategoryValidator>();
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
        }
    }
}
