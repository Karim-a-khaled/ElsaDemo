using Microsoft.Extensions.DependencyInjection;

namespace ElsaWorkflows.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddElsa(this IServiceCollection services)
    {
        return services;
    }
}
