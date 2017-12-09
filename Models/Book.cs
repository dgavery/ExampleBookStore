using System;
using System.Collections.Generic;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;

namespace NuggetBookStore.Models
{
    public class Book : Identifiable
    {
        [Attr("title")]
        public string Title { get; set; }
        [Attr("isbn")]
        public string ISBN { get; set; }
        [Attr("publish-date")]
        public DateTime PublishDate { get; set; }
        [HasOne("author")]
        public virtual Author Author { get; set; }
        [HasMany("reviews")]
        public virtual List<Review> Reviews { get; set; }

    }
}