using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Interfaces
{
    public interface IBrandService
    {
        void Create(Brand brand);
        Brand GetById(int id);
        List<Brand> GetAll();
        void Update(int id, Brand brand);
        void Delete(int id);
    }
}
