namespace Core.Commands
{
    using System.Threading.Tasks;

    public interface ICommandDispatcher
    {
        Task<CommandResult<TValue>> ExecuteAsync<TValue>(ICommand<TValue> command);
    }
}