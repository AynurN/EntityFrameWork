using CarsERP.Interfaces;
using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Implementations
{
    public class ColorService: IColorService
    {
        AppDbContext context = new AppDbContext();
        public void Create(Color color)
        {
            context.Colors.Add(color);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Color? wanted = context.Colors.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            context.Colors.Remove(wanted);
            context.SaveChanges();
        }

        public List<Color> GetAll()
        {
            return context.Colors.ToList();
        }

        public Color GetById(int id)
        {
            Color? wanted = context.Colors.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            return wanted;
        }

        public void Update(int id, Color color)
        {
            Color? wanted = context.Colors.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            wanted = color;
            context.SaveChanges();

        }
    }
}
