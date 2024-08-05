using FA.Client.Be.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<FADbContext>((serviceProvider, options) =>
    {
        options.UseNpgsql("User ID=postgres;Password=MySecretPassword123$;Host=192.168.0.27;Port=5432;Database=postgres;Pooling=true;", (b) =>
        {
            b.MigrationsHistoryTable("migrations_history");
            b.MigrationsAssembly("FA.Client.Be");
        });
    });

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.MapControllers();

app.Run();