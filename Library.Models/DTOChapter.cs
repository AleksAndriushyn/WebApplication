using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOChapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        public DTOBook Book { get; set; }
    }
}
