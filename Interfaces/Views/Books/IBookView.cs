using Models.Books;
using System.Collections.Generic;

namespace Interfaces.Views.Books
{
    public interface IBookView
    {
        void SetBooks(IEnumerable<Book> books);
        void SetBindings(IEnumerable<Binding> bindings);
    }
}
