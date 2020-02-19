
namespace Core.Commands.DependencyResolver
{
    using System;

    public interface IDependencyResolver : IDisposable
    {
        object Resolve(Type typeToResolve);
    }
}