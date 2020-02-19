namespace Core.Commands
{
    public interface ICommand<TValue>
    {
    }

    public interface ICommand : ICommand<EmptyValue>
    {
    }
}
