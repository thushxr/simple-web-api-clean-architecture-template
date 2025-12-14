using Thushar.Example.Project.Application;
using Thushar.Example.Project.Infrastructure;

namespace Thushar.Example.Project.HttpApi.Host
{
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                builder.Services.AddAuthorization();
                builder.Services.AddControllers();
                builder.Services.AddApplicationService();
                builder.Services.AddInfrastructureService(builder.Configuration);

                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                var app = builder.Build();

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
