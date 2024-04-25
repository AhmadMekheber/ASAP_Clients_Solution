using Clients.Migrations.Data;
using Clients.DI;
using Microsoft.EntityFrameworkCore;
using Mails.Service.Hosts;

var builder = WebApplication.CreateBuilder(args);

//To Run Migrations:
//Run this command from this service project directory
//dotnet ef migrations add Initial --project ../Clients.Migrations
//
//To Update Database Run: dotnet ef Database update
//
builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Clients.Migrations"));
});

builder.Services.AddCoreServices();

builder.Services.AddHttpClient();

builder.Services.AddHostedService<ClientsMailService>();

var app = builder.Build();

app.Run();
