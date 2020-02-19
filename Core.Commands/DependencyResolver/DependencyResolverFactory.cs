
namespace Core.Commands.DependencyResolver
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class DependencyResolverFactory : IDependencyResolverFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DependencyResolverFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDependencyResolver CreateDependencyResolver()
        {
            return new DependencyResolver(_serviceProvider.CreateScope());
        }
    }
}
