using Microsoft.Extensions.DependencyInjection;

namespace Domain.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        return services;
    } 
}
