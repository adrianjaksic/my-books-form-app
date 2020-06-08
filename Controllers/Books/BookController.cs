using Interfaces.Repository.Books;
using Interfaces.Views.Books;
using Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controllers.Books
{
    public class BookController
    {
        private readonly IBookView _view;
        private readonly IBookRepository _bookRepository;
        private readonly IBindingRepository _bindingRepository;
        private IEnumerable<Book> _books;

        public BookController(IBookView view, IBookRepository bookRepository, IBindingRepository bindingRepository)
        {
            _view = view;
            _bookRepository = bookRepository;
            _bindingRepository = bindingRepository;
        }

        public void Initialization()
        {
            _view.SetBindings(_bindingRepository.GetBindings());
        }

        public void LoadBooks(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }

            _books = _bookRepository.LoadBooks(filePath);
            _view.SetBooks(_books);
        }

        public void DeleteBooksNotInStock()
        {
            if (_books == null)
            {
                throw new ApplicationException("Books are not loaded");
            }

            _books = _books.Where(b => b.InStock).ToList();
            _view.SetBooks(_books);
        }
    }
}
