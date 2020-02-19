using Core.Commands.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IDependencyResolverFactory _resolverFactory;

        public CommandDispatcher(IDependencyResolverFactory resolverFactory)
        {
            _resolverFactory = resolverFactory;
        }

        public async Task<CommandResult<TValue>> ExecuteAsync<TValue>(ICommand<TValue> command)
        {
            using (var resolver = _resolverFactory.CreateDependencyResolver())
            {
                var compandType = command.GetType();
                var value = typeof(TValue);
                var handlerType = typeof(ICommandHandler<,>).MakeGenericType(compandType, value);

                dynamic handler = resolver.Resolve(handlerType);

                return (CommandResult<TValue>)(await handler.ExecuteAsync((dynamic)command));
            }
        }
    }
}
