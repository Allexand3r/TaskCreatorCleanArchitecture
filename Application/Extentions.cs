using Application.Notes.Interfaces;
using Application.Notes.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public  static class Extentions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();
        return services;
    }
}