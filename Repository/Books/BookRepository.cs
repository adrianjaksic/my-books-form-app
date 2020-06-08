using Core.Exceptions;
using Interfaces.Repository.Books;
using Models.Books;
using Repository.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Repository.Books
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> LoadBooks(string filePath)
        {
            var lines = File.ReadAllLines(filePath).Select(a => a.Split(';'));            
            try
            {
                //skipping titles
                return lines.Skip(1).Select(x => x.ToBook()).ToList();
            }
            catch (ArgumentException exc)
            {
                throw new WrongDataException("books", exc);
            }            
        }
    }
}
