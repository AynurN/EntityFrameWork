using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Interfaces
{
    public interface IColorService
    {
        void Create(Color color);
        Color GetById(int id);
        List<Color> GetAll();
        void Update(int id, Color color);
        void Delete(int id);
    }
}
