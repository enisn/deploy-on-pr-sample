﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace DeployOnPrSample.Data;

public class DeployOnPrSampleEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public DeployOnPrSampleEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the DeployOnPrSampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DeployOnPrSampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
