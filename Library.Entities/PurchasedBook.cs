using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Entities
{
    public class PurchasedBook
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Books { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
