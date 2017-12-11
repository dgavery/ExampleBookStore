
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using ExampleBookStore.Models;

namespace ExampleBookStore.Controllers
{
    public class BooksController : JsonApiController<Book>
    {
        public BooksController(
                IJsonApiContext jsonApiContext,
                IResourceService<Book> resourceService,
                ILoggerFactory loggerFactory)
            : base(jsonApiContext, resourceService, loggerFactory)
            { }

    }
}