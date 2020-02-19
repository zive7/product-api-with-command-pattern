namespace Core.Commands
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static void AddCommands(this IServiceCollection services)
        {
            var assemplies = AppDomain.CurrentDomain.GetAssemblies();

            services.Scan(scan => scan
                .FromAssemblies(assemplies)
                .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<,>)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());

            services.AddTransient<ICommandDispatcher, CommandDispatcher>();
        }
    }
}
