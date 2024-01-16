using System;
using System.Collections.Generic;

namespace WebBookstore.Models
{
    public partial class Bookstore
    {
        public int BookId { get; set; }
        public string PublisherName { get; set; } = null!;
        public string? Address { get; set; }
        public int? AuthorId { get; set; }
        public string? BookName { get; set; }
        public string? BookCategory { get; set; }
        public int? Price { get; set; }
    }
}
