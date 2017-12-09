
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using NuggetBookStore.Models;

namespace NuggetBookStore.Controllers
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