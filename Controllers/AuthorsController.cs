
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using ExampleBookStore.Models;

namespace ExampleBookStore.Controllers
{
    public class AuthorsController : JsonApiController<Author>
    {
        public AuthorsController(
                IJsonApiContext jsonApiContext,
                IResourceService<Author> resourceService,
                ILoggerFactory loggerFactory)
            : base(jsonApiContext, resourceService, loggerFactory)
            { }


    }
}