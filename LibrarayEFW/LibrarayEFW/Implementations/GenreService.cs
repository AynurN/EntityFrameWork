using LibrarayEFW.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayEFW.Implementations
{
    public class GenreService : IGenreService
    {
        public void Create(Genre genre)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Genres.Add(genre);
            appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {

            AppDbContext appDbContext = new AppDbContext();
            Genre? wantedGenre = appDbContext.Genres.Find(id);
            if (wantedGenre == null)
                throw new NullReferenceException();
            appDbContext.Genres.Remove(wantedGenre);
            appDbContext.SaveChanges();
        }

        public List<Genre> GetAll()
        {
            AppDbContext appDbContext = new AppDbContext();
            return appDbContext.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            Genre? wantedGenre = appDbContext.Genres.Find(id);
            if (wantedGenre == null)
                throw new NullReferenceException();
            return wantedGenre;
        }

        public void Update(int id, Genre genre)
        {
            AppDbContext appDbContext = new AppDbContext();
            Genre? wantedGenre = appDbContext.Genres.Find(id);
            if (wantedGenre == null)
                throw new NullReferenceException();
            wantedGenre.Name=genre.Name;
            appDbContext.SaveChanges();
        }
    }
}
