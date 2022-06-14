using Library.Bl.Abstract;
using Library.DAL.Impl.Mappers;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Bl.Impl
{
    public class LibraryService: ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IAuthors_BookService _authorsBookService;
        private readonly IRecommendedBookService _recommendedBookService;
        public LibraryService(IAuthorService authorService, IAuthors_BookService authorsBookService, IRecommendedBookService recommendedBookService)
        {
            _authorService = authorService;
            _authorsBookService = authorsBookService;
            _recommendedBookService = recommendedBookService;
        }
        
        public IEnumerable<DTOAuthor> FindByAmountOfBooks(int amountOfBooks)
        {
            List<Author> authors = new List<Author>();
            foreach (var a in _authorService.EntityList())
            {
                if(_authorsBookService.List(obj => obj.AuthorId == a.Id).Count() == amountOfBooks)
                {
                    authors.Add(a);
                }
            }
            return authors.Select(obj => AuthorMapper.Map(obj)).ToList();
        }

        public IEnumerable<DTORecommendedBook> GetRecommendedBook()
        {
            return _recommendedBookService.List();
        }
    }
}
