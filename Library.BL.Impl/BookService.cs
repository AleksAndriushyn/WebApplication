using Library.Bl.Abstract;
using Library.DAL.Impl;
using Library.DAL.Impl.Mappers;
using Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.Bl.Impl
{
    public class BookService : BookRepository, IBookService
    {
        private readonly IRecommendedBookService _recommendedBookService;
        List<DTOBook> recommendedBooks = new List<DTOBook>();
        public BookService(LibraryContext context, IRecommendedBookService recommendedBookService) : base(context)
        {
            _recommendedBookService = recommendedBookService;
        }
       
        public List<DTOBook> List()
        {
            return this.EntityList().Select(obj => BookMapper.Map(obj)).ToList();
        }
        public void Insert(DTOBook book)
        {
            this.EntityInsert(BookMapper.Unmap(book));
        }

        public DTOBook Get(int id)
        {
            return BookMapper.Map(this.GetEntity(id));
        }

        public void Update(DTOBook model)
        {
            this.UpdateEntity(BookMapper.Unmap(model));
        }
        public IEnumerable<DTOBook> FindByTitle(string searchTitle)
        {
            var books = this.EntityList();
            books = books.Where(s => s.Title.ToLower().Contains(searchTitle)).ToList();
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }

        public IEnumerable<DTOBook> GetBookInfo(DTOBook book)
        {
            var books = this.EntityList();
            books = books.Where(s => s.Id == book.Id).ToList();
            foreach (var b in books)
                _recommendedBookService.Insert(new DTORecommendedBook() {Title=b.Title, Text=b.Text, Price=b.Price, Pages=b.Pages});
            
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }

        public IEnumerable<DTOBook> GetRecommendedBooks()
        {
            var tempRecommendedBooks = _recommendedBookService.List();
            foreach(var rb in tempRecommendedBooks)
            {
                recommendedBooks.Add(new DTOBook() { Title = rb.Title, Text = rb.Text, Price = rb.Price, Pages = rb.Pages });
            }

            return recommendedBooks.ToList();
        }
    }
}
