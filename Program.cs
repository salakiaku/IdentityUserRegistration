using IdentityUserRegistration;
using IdentityUserRegistration.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Registra a context do Banco de Dados e o IDentity e  define o mesmo contexto para o Identrity User
builder.Services.AddDbContext<DataBaseContext>(option=> option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddIdentity<User,IdentityRole>()
    .AddEntityFrameworkStores<DataBaseContext>();
builder.Services.AddAutoMapper(typeof(Program));
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
