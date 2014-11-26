﻿using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using System;

namespace Glimpse
{
    public static class GlimpseServerServiceCollectionExtensions
    {
        public static IServiceCollection RunningServer(this IServiceCollection services)
        {
            return services.Add(GlimpseServerServices.GetDefaultServices());
        }

        public static IServiceCollection RunningServer(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Add(GlimpseServerServices.GetDefaultServices(configuration));
        }
    }
}