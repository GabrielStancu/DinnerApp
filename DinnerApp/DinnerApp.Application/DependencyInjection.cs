namespace DinnerApp.Application;

public static class DependencyInjection
{
    public static void AddApplication(IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}
