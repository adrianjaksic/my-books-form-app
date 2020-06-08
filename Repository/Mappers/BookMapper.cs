using Models.Books;
using System;

namespace Repository.Mappers
{
    public static class BookMapper
    {
        public static Book ToBook(this string[] array)
        {
            if (array == null || array.Length < 7)
            {
                throw new ArgumentException("array has invlaid number of elements");
            }
            return new Book()
            {
                Title = array[0],
                Author = array[1],
                Year = array[2],
                Price = decimal.Parse(array[3]),
                InStock = ParseInStock(array[4]),
                Binding = array[5],
                Description = array[6],
            };
        }

        private static bool ParseInStock(string value)
        {
            switch (value.ToLower())
            {
                case "yes":
                case "true":
                    return true;
                default:
                    return false;
            }
        }
    }
}
