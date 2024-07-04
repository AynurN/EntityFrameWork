using LibrarayEFW.Implementations;
using LibrarayEFW.Interfaces;

namespace LibrarayEFW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Genre g1 = new Genre() { Name = "Sci-Fi" };
            Book b1 = new Book() { Name = "Brave new World", CostPrice = 20, SalePrice = 23, GenreId = 1 };
            Book b2 = new Book() { Name = "Dune", CostPrice = 25, SalePrice = 40, GenreId = 1 };
            IGenreService genreService = new GenreService();
            //genreService.Create(g1);
            //foreach (var item in genreService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
            IBookService bookService = new BookService();
            //bookService.Create(b1);
            //bookService.Create(b2);
            //Console.WriteLine(bookService.GetById(1));
            //bookService.Delete(1);
            //foreach (var item in bookService.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}
            bookService.Update(2, b2);
            Console.WriteLine(bookService.GetById(2));
        }
    }
}
