using MHS.Data.Repositories;
using MHS.Api.Services;
using MHS.Api.Vendors;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IComponentsRepository, ComponentsRepository>();
            builder.Services.AddSingleton<ITransportOrdersStatusRepository, TransportOrdersStatusRepository>();
            builder.Services.AddSingleton<ITransportOrdersRepository, TransportOrdersRepository>();
            builder.Services.AddSingleton<IServiceFactory, ServiceFactory>();
            builder.Services.AddTransient<ICommandService, MHS.Api.Vendors.VendorA.TransportOrderService>();
            builder.Services.AddTransient<ICommandService, MHS.Api.Vendors.VendorB.TransportOrderService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}