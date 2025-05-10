using Infrastructure.Repositories.Implementation;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Extentions
{
    public static IServiceCollection AddDataAccses(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(option => 
            option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<INoteRepository, NoteRepository>();

        return services;
    }
}