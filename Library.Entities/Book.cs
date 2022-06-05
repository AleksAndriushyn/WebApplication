using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book 
    {
        [Key]
        public int Id { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
        public virtual ICollection<Authors_Book> Authors_Books { get; set; }
        public virtual ICollection<Readers_Card> Readers_Cards { get; set; }
    }
}
