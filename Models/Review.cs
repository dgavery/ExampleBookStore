using System;
using System.Collections.Generic;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;

namespace NuggetBookStore.Models
{
    public class Review : Identifiable
    {
        [Attr("reviewer-name")]
        public string ReviewerName { get; set; }
        [Attr("body")]
        public string Body { get; set; }
        [HasOne("book")]
        public virtual Book Book { get; set; }
    }
}