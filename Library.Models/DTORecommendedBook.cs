using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class DTORecommendedBook
    {
        public int Id { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
    }
}
