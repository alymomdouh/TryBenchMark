
using BenchmarkDotNet.Running;
using TryBenchMark.services;

namespace TryBenchMark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IBenchMarkService, BenchMarkService>();

            BenchmarkRunner.Run<BenchMarkService>();
            // to try BenchMarkService
            //dotnet build -c Release
            //dotnet  bin\Release\net8.0\TryBenchMark.dll

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
