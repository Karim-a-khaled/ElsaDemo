﻿using Microsoft.Extensions.DependencyInjection;

namespace Application.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
