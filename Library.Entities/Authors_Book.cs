using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Authors_Book 
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("AuthorId")]
        public Author Authors { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("BookId")]
        public Book Books { get; set; }
        public int BookId { get; set; }
    }
}
