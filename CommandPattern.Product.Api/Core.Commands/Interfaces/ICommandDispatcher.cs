namespace Core.Commands.Interfaces
{
    using System.Threading.Tasks;

    public interface ICommandDispatcher
    {
        Task<CommandResult<TValue>> ExecuteAsync<TValue>(ICommand<TValue> command);
    }
}