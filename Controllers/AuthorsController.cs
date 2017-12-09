
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using NuggetBookStore.Models;

namespace NuggetBookStore.Controllers
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