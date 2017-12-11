using System.Collections.Generic;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;

namespace ExampleBookStore.Models
{
    public class Author : Identifiable
    {
        [Attr("first-name")]
        public string FirstName { get; set; }
        [Attr("last-name")]
        public string LastName { get; set; }
        [HasMany("books")]
        public virtual List<Book> Books { get; set; }
    }
}