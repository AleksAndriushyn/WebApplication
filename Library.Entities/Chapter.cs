using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Chapter 
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Books { get; set; }
    }
}
