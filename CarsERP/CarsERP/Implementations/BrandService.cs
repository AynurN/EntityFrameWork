using CarsERP.Interfaces;
using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Implementations
{
    public class BrandService: IBrandService
    {
        AppDbContext context = new AppDbContext();
        public void Create(Brand brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Brand? wanted = context.Brands.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            context.Brands.Remove(wanted);
            context.SaveChanges();
        }

        public List<Brand> GetAll()
        {
            return context.Brands.ToList();
        }

        public Brand GetById(int id)
        {
            Brand? wanted = context.Brands.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            return wanted;
        }

        public void Update(int id, Brand brand)
        {
            Brand? wanted = context.Brands.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            wanted = brand;
            context.SaveChanges();

        }
    }
}
