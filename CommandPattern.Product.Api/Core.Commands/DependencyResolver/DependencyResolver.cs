namespace Core.Commands.DependencyResolver
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class DependencyResolver : IDependencyResolver
    {
        private readonly IServiceScope _serviceScope;

        internal DependencyResolver(IServiceScope serviceScope)
        {
            _serviceScope = serviceScope;
        }

        public object Resolve(Type typeToResolve)
        {
            return _serviceScope.ServiceProvider.GetService(typeToResolve);
        }

        public void Dispose()
        {
            _serviceScope.Dispose();
        }
    }
}