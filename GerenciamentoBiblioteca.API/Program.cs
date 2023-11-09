using GerenciamentoBiblioteca.Data.Context;
using LibraryManagement.Application;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.Repositories;
using LibraryManagement.Domain.Interfaces.Repositories;
using LibraryManagement.Domain.Interfaces.Services;
using LibraryManagement.Domain.Services;
using LibraryManagement.IOC;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("GerenciamentoBiblioteca");
        builder.Services.AddDbContext<LibraryManagementContext>(x => x.UseSqlServer(connectionString));

        #region Maping
        builder.Services.AddAutoMapper(typeof(ModuleIOC));
        builder.Services.AddScoped<IAuthorAppService, AuthorAppService>();
        builder.Services.AddScoped<IAuthorService, AuthorService>();
        builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
        #endregion

        builder.Services.AddControllers();
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