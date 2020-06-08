using Models.Books;
using System.Collections.Generic;

namespace Interfaces.Repository.Books
{
    public interface IBookRepository
    {
        /// <summary>
        /// Reading books.
        /// </summary>
        /// <param name="filePath">Path from where books are read</param>
        /// <returns>Books</returns>
        /// <exception cref="WrongDataException"></exception>
        IEnumerable<Book> LoadBooks(string filePath);
    }
}
