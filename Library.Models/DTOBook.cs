using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTOBook
    {
        public int Id { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public List<DTOChapter> Chapters { get; set; }
        public List<DTOAuthors_Book> Authors_Books { get; set; }
        public List<DTOReaders_Card> Readers_Cards { get; set; }
        public List<DTOPurchasedBook> Purchased_Books { get; set; }
    }
}
