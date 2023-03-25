using DinnerApp.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerApp.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}
