using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Impl.Mappers
{
    public class ChapterMapper
    {
        public static DTOChapter Map(Chapter entity)
        {
            return new DTOChapter()
            {
                Id = entity.Id,
                Title = entity.Title,
                BookId = entity.BookId
                //Book = BookMapper.Map(entity.Book)
            };
        }
        public static Chapter Unmap(DTOChapter model)
        {
            return new Chapter()
            {
                Id = model.Id,
                Title = model.Title,
                BookId = model.BookId
            };
        }
    }
}
