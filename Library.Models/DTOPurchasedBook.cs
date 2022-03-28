using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class DTOPurchasedBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DTOBook Books { get; set; }
        public DateTime Date { get; set; }
    }
}
