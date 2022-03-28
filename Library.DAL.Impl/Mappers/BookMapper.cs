using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class BookMapper
    {
        public static DTOBook Map(Book entity)
        {
            return new DTOBook()
            {
                Id = entity.Id,
                Pages = entity.Pages,
                Title = entity.Title,
                Text = entity.Text,
                Price = entity.Price
                //Chapters = entity.Chapters.Select(obj => ChapterMapper.Map(obj)).ToList(),
                //Authors_Books = entity.Authors_Books.Select(obj => Authors_BookMapper.Map(obj)).ToList(),
                //Readers_Cards = entity.Readers_Cards.Select(obj => Readers_CardMapper.Map(obj)).ToList()
            };
        }
        public static Book Unmap(DTOBook model)
        {
            return new Book()
            {
                Id = model.Id,
                Pages = model.Pages,
                Title = model.Title,
                Text = model.Text,
                Price = model.Price
            };
        }
    }
}
