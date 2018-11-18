using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftBroApi.Reposetory.EFCore;
using LiftBroApi.Reposetory.EFCore.Reposetorys;
using LiftBroApi.Reposetory.EFCore.SeedingData;
using LiftBroApi.Reposetory.Interfaces;
using LiftBroAPI.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LiftBroApi
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
            LiftBroContext context = new LiftBroContext();

            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                LiftBroDBInitializer.Seed(context);//<---Do your seeding here

            }

            services.AddDbContext<LiftBroContext>();


            services.AddScoped<IUserReposetory>(s => new UserReposetory(context));
            services.AddScoped<IWorkoutReposetory>(s => new WorkoutReposetory(context));
            services.AddScoped<IExerciseReposetory>(s => new ExerciseReposetory(context));
            services.AddScoped<IActivityReposetory>(s => new ActivityReposetory(context));

            services.AddMvc();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}