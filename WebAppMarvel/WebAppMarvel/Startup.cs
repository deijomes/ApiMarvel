using Microsoft.AspNetCore.Routing.Constraints;
using WebAppMarvel.Servicios;

namespace WebAppMarvel
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpClient<IPersonajeSerie,PersonajeSerie>("MyApi", client =>
            {
                client.BaseAddress = new Uri(Configuration["MyApi:Url"]);

            });
            services.AddHttpClient("credencial", client =>
            {
                client.BaseAddress = new Uri(Configuration["credencial:token"]);

            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(Startup));
            

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
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
