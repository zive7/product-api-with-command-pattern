namespace Core.Commands
{
    using System.Threading.Tasks;

    public interface ICommandHandler<in TCommand, TValue> where TCommand : ICommand<TValue>
    {
        Task<CommandResult<TValue>> ExecuteAsync(TCommand command);
    }

    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, EmptyValue>
    where TCommand : ICommand<EmptyValue>
    {
    }
}