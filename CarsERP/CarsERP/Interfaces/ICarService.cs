using CarsERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Interfaces
{
    public interface ICarService
    {
        void Create(Car car);
        Car GetById(int id);
        List<Car> GetAll();
        void Update(int id,  Car car);
        void Delete(int id);
        void AssignColorToCar(int carId, int colorId);

    }
}
