using Library.Bl.Abstract;
using Library.DAL.Impl.Mappers;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Controllers;
using Xunit;

namespace Library.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void BookService_GetBookInfo_GetText()
        {
            var mockBookService = new Mock<IBookService>();
            
            mockBookService.Setup(repo => repo.List())
                .Returns(GetTestBooks());
            
            var book = new Book() { Id = 7, Text = "text" };

            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = controller.GetBookInfo(book);

            // Assert
            var viewResult = Assert.IsType<Book>(result);
            Assert.Equal(book.Text, viewResult?.Text);
        }

        private List<DTOBook> GetTestBooks()
        {
            var books = new List<Book>();
            books.Add(new Book()
            {
                Price = 30,
                Id = 7,
                Title = "Book One",
                Pages = 200
            });
            books.Add(new Book()
            {
                Price = 70,
                Id = 9,
                Title = "Book Two",
                Pages = 400
            });
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }
    }
}
