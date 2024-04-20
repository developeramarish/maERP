﻿using maERP.Persistence.Configurations.Options;
using maERP.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace maERP.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IOptions<DatabaseOptions> dbOptions)
    {
        var test = dbOptions.Value.DefaultConnection;
        
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(dbOptions.Value.DefaultConnection);
        });

        return services;
    }
}