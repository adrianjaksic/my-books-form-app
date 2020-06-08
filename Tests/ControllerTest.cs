using Controllers.Books;
using Interfaces.Repository.Books;
using Interfaces.Views.Books;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Books;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void TestLoadBooks()
        {
            Mock<IBookView> bookView = new Mock<IBookView>();
            Mock<IBookRepository> bookRepository = new Mock<IBookRepository>();
            Mock<IBindingRepository> bindingRepository = new Mock<IBindingRepository>();
            var testBooks = GetTestBooksWithInStockTrue(2);
            bookRepository.Setup(br => br.LoadBooks(It.IsAny<string>())).Returns(testBooks.ToList());
            var controller = new BookController(bookView.Object, bookRepository.Object, bindingRepository.Object);
            
            controller.LoadBooks("some path");
            
            bookView.Verify(bv => bv.SetBooks(testBooks));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullFilepath()
        {
            Mock<IBookView> bookView = new Mock<IBookView>();
            Mock<IBookRepository> bookRepository = new Mock<IBookRepository>();
            Mock<IBindingRepository> bindingRepository = new Mock<IBindingRepository>();
            var controller = new BookController(bookView.Object, bookRepository.Object, bindingRepository.Object);
            
            controller.LoadBooks(null);
        }

        [TestMethod]
        public void TestDeleteBooksNotInStock()
        {
            Mock<IBookView> bookView = new Mock<IBookView>();
            Mock<IBookRepository> bookRepository = new Mock<IBookRepository>();
            Mock<IBindingRepository> bindingRepository = new Mock<IBindingRepository>();
            var testBooks = GetTestBooksWithInStockTrue(10);
            testBooks[9].InStock = false;
            bookRepository.Setup(br => br.LoadBooks(It.IsAny<string>())).Returns(testBooks);
            var controller = new BookController(bookView.Object, bookRepository.Object, bindingRepository.Object);

            controller.LoadBooks("some path");
            controller.DeleteBooksNotInStock();

            Assert.AreEqual(9, controller.BooksCount);
        }

        private List<Book> GetTestBooksWithInStockTrue(int number)
        {
            var resultList = new List<Book>();
            for (int i = 0; i < number; i++)
            {
                resultList.Add(new Book() 
                {
                    Title = $"Book_{i}",
                    InStock = true,
                });
            }
            return resultList;
        }
    }
}
