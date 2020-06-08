namespace Models.Books
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Year { get; set; }
        public string Binding { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
    }
}
