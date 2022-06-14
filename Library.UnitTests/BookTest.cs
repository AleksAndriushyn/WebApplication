using Library.Bl.Abstract;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using WebApplication1.Controllers;
using Xunit;

namespace Library.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void BookService_Index_Book()
        {
            var mockBookService = new Mock<IBookService>();
            mockBookService.Setup(repo => repo.List())
                .Returns(new List<DTOBook>());
            
            var booksController = new BooksController(mockBookService.Object);

            // Act
            var result = booksController.Index("war");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<List<DTOBook>>(viewResult.Model);
        }

        [Fact]
        public void BookService_GetBookInfo_GetText()
        {
            var mockBookService = new Mock<IBookService>();

            mockBookService.Setup(repo => repo.List())
                .Returns(new List<DTOBook>());

            var book = new DTOBook() { Id = 7, Title = "War", Text = "text" };

            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = controller.GetBookInfo(book);

            // Assert
            ViewResult viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<DTOBook[]>(viewResult.Model);
        }
    }
}
