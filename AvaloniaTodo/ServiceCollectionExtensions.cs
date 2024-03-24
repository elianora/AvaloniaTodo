using AvaloniaTodo.Services;
using AvaloniaTodo.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaTodo;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection services)
    {
        services.AddTransient<ToDoListService>();
        services.AddTransient<MainWindowViewModel>();
    }
}
