using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOAuthors_Book
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public DTOAuthor Author { get; set; }
        public DTOBook Book { get; set; }
    }
}
