﻿using Google.Cloud.EntityFrameworkCore.Spanner.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.Design.Internal
{
    public class SpannerDesignTimeServices : IDesignTimeServices
    {
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
            => serviceCollection
                .AddSingleton<LoggingDefinitions, SpannerLoggingDefinitions>()
                .AddSingleton<IRelationalTypeMappingSource, SpannerTypeMappingSource>()
                .AddSingleton<IDatabaseModelFactory, SpannerDatabaseModelFactory>()
                .AddSingleton<IProviderConfigurationCodeGenerator, SpannerCodeGenerator>()
                .AddSingleton<IAnnotationCodeGenerator, SpannerAnnotationCodeGenerator>();
    }
}
