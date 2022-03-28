using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class Readers_Card 
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Books { get; set; }
        public int ReaderId { get; set; }
        [ForeignKey("ReaderId")]
        public Reader Readers { get; set; }
    }
}
