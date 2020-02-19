namespace Product.Api.Controllers
{
    using Core.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Product.Api.Commands;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public ProductsController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        public async Task<ActionResult> GetProductsAsync()
        {
            var command = new GetProductsCommand();

            CommandResult<List<Models.Product>> result = await _commandDispatcher.ExecuteAsync(command);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromQuery] string name)
        {
            var command = new CreateProductCommand(Guid.NewGuid(), name);

            CommandResult<Models.Product> result = await _commandDispatcher.ExecuteAsync(command);

            return Ok(result);
        }
    }
}