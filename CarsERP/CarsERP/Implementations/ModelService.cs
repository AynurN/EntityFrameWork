using CarsERP.Interfaces;
using CarsERP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Implementations
{
    public class ModelService : IModelService
    {
        AppDbContext context = new AppDbContext();
        public void Create(Model model)
        {
            context.Models.Add(model);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Model? wanted = context.Models.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            context.Models.Remove(wanted);
            context.SaveChanges();
        }

        public List<Model> GetAll()
        {
            return context.Models.AsNoTracking().Include(x=>x.Brand).ToList();
        }

        public Model GetById(int id)
        {
            Model? wanted = context.Models.Include(x=>x.Brand).FirstOrDefault(x=>x.Id==id);
            if (wanted == null)
                throw new NullReferenceException();
            return wanted;
        }

        public void Update(int id, Model model)
        {
            Model? wanted = context.Models.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            wanted = model;
            context.SaveChanges();


        }
       
    }
}
