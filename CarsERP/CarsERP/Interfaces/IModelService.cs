using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Interfaces
{
    public interface IModelService
    {
        void Create(Model model);
        Model GetById(int id);
        List<Model> GetAll();
        void Update(int id, Model model);
        void Delete(int id);
    }
}
