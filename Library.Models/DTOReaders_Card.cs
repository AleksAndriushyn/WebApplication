using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOReaders_Card
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int BookId { get; set; }
        public DTOBook Books { get; set; }
        public int ReaderId { get; set; }
        public DTOReader Reader { get; set; }
    }
}
