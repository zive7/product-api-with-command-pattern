namespace Product.Api.Commands
{

    using Core.Commands;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Product.Api.Models;

    public class GetProductsCommand : ICommand<List<Product>>
    {
    }

    public class GetProductsCommandHandler : ICommandHandler<GetProductsCommand, List<Product>>
    {
        public async Task<CommandResult<List<Product>>> ExecuteAsync(GetProductsCommand command)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ Name ="Person 1", Uid= Guid.NewGuid() },
                new Product{ Name ="Person 2", Uid= Guid.NewGuid() },
                new Product{ Name ="Person 3", Uid= Guid.NewGuid() },
                new Product{ Name ="Person 4", Uid= Guid.NewGuid() },
            };

            return await Task.FromResult(new CommandResult<List<Product>>(true, "OK", products, HttpStatusCode.OK));
        }
    }
}
