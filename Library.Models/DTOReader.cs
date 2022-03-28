using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOReader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<DTOReaders_Card> Readers_Cards { get; set; }
    }
}
