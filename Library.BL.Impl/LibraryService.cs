using Library.Bl.Abstract;
using Library.DAL.Abstract;
using Library.DAL.Impl.Mappers;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Bl.Impl
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IAuthors_BookRepository _authorsBookRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IPurchasedBookRepository _purchasedBookRepository;
        public LibraryService(IAuthorRepository authorRepository, IAuthors_BookRepository authorsBookRepository, IBookRepository bookRepository, IPurchasedBookRepository purchasedBookRepository)
        {
            _authorRepository = authorRepository;
            _authorsBookRepository = authorsBookRepository;
            _bookRepository = bookRepository;
            _purchasedBookRepository = purchasedBookRepository;
        }
        public IEnumerable<DTOAuthor> FindByAmountOfBooks(int AmountOfBooks)
        {
            List<Author> authors = new List<Author>();
            foreach (var a in _authorRepository.EntityList())
            {
                if(_authorsBookRepository.List(obj => obj.AuthorId == a.Id).Count() == AmountOfBooks)
                {
                    authors.Add(a);
                }
            }
            return authors.Select(obj => AuthorMapper.Map(obj)).ToList();
        }
        public IEnumerable<DTOBook> GetRecommendedBook()
        {
            List<Book> recommendedBooks = new List<Book>();
            foreach (Book b in _bookRepository.EntityList())
            {
                foreach(PurchasedBook pb in _purchasedBookRepository.EntityList())
                {
                    if (b.Id == pb.BookId)
                        recommendedBooks.Add(b);
                }
                //if(_purchasedBookRepository.GetEntity(1).BookId==b.Id)
                //    recommendedBooks.Add(b);
            }
            return recommendedBooks.Select(obj=>BookMapper.Map(obj));
        }
    }
}
