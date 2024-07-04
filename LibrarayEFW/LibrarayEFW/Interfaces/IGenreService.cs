using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayEFW.Interfaces
{
    public interface IGenreService
    {
        void Create(Genre genre);
        Genre GetById(int id);
        List<Genre> GetAll();
        void Update(int id,Genre genre);
        void Delete(int id);
    }
}
