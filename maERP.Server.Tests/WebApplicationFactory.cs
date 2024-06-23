﻿using maERP.Persistence.DatabaseContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace maERP.Server.Tests;

public class maERPWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(
            // ReSharper disable once AsyncVoidLambda
            async services =>
            {
                var descriptor = services.Single(
                    d => d.ServiceType ==
                         typeof(DbContextOptions<ApplicationDbContext>)
                );

                services.Remove(descriptor);

                services.AddDbContext<ApplicationDbContext>(
                    options =>
                    {
                        options.UseInMemoryDatabase("MemoryDB");
                        options.ConfigureWarnings(configurationBuilder => configurationBuilder.Ignore(InMemoryEventId.TransactionIgnoredWarning));
                    }
                );

                await Task.CompletedTask;
            }
        );
    }

    public async Task InitializeDbForTests<T>(List<T>? seedData = null) where T : class
    {
        using var scope = Services.CreateScope();
        var scopedServices = scope.ServiceProvider;
        var db = scopedServices.GetRequiredService<ApplicationDbContext>();
        await db.Database.EnsureDeletedAsync();
        await db.Database.EnsureCreatedAsync();

        if (seedData != null)
        {
            await db.Set<T>().AddRangeAsync(seedData);
            await db.SaveChangesAsync();
        }
    }

    public async Task InitializeDbForTests()
    {
        using var scope = Services.CreateScope();
        var scopedServices = scope.ServiceProvider;
        var db = scopedServices.GetRequiredService<ApplicationDbContext>();
        await db.Database.EnsureDeletedAsync();
        await db.Database.EnsureCreatedAsync();
    }
}