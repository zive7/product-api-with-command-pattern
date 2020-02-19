namespace Product.Api.Commands
{
    using Core.Commands;
    using System;
    using System.Net;
    using System.Threading.Tasks;

    public class CreateProductCommand : ICommand<Models.Product>
    {
        public Guid Uid { get; }

        public string Name { get; }

        public CreateProductCommand(Guid uid, string name)
        {
            Uid = uid;
            Name = name;
        }
    }

    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Models.Product>
    {
        public async Task<CommandResult<Models.Product>> ExecuteAsync(CreateProductCommand command)
        {
            return await Task.FromResult(new CommandResult<Models.Product>(true, "OK", new Models.Product() { Name = command.Name, Uid = command.Uid}, HttpStatusCode.OK));
        }
    }
}