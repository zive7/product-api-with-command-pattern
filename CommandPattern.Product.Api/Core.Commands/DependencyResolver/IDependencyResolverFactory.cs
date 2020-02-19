using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands.DependencyResolver
{
    public interface IDependencyResolverFactory
    {
        IDependencyResolver CreateDependencyResolver();
    }
}
