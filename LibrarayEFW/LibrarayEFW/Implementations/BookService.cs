using LibrarayEFW.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayEFW.Implementations
{
    public class BookService : IBookService
    {
        public void Create(Book book)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.Add(book);
            appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            Book? wantedBook = appDbContext.Books.Find(id);
            if (wantedBook== null)
                throw new NullReferenceException();
            appDbContext.Books.Remove(wantedBook);
            appDbContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            AppDbContext appDbContext = new AppDbContext();
            return appDbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            Book? wantedBook = appDbContext.Books.Include(x=>x.Genre).FirstOrDefault(x=>x.Id==id);
            if (wantedBook == null)
                throw new NullReferenceException();
            return wantedBook;
        }

        public void Update(int id,Book book)
        {
            AppDbContext appDbContext = new AppDbContext();
            Book? wantedBook = appDbContext.Books.Find(id);
            if (wantedBook == null)
                throw new NullReferenceException();
            wantedBook.Name = book.Name;
            wantedBook.SalePrice = book.SalePrice;
            wantedBook.CostPrice = book.CostPrice;
            wantedBook.GenreId = book.GenreId;
            appDbContext.SaveChanges();

        }
    }
}
