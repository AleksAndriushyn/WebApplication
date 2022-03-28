using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOAuthor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DTOAuthors_Book> Authors_Books { get; set; }
    }
}
