using CarsERP.Interfaces;
using CarsERP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Implementations
{
    public class CarService : ICarService
    {
        AppDbContext context = new AppDbContext();
        public void Create(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
           
        }

        public void Delete(int id)
        {
            Car? wanted = context.Cars.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            context.Cars.Remove(wanted);
            context.SaveChanges();
        }

        public List<Car> GetAll()
        {
           return context.Cars.Include(x=>x.Model).ThenInclude(x=>x.Brand).Include(x=>x.CarColors).ThenInclude(x=>x.Color).ToList();
        }

        public Car GetById(int id)
        {
            List<Car> cars = context.Cars.Where(x => x.Id == id).Include(x=>x.Model).Include(x => x.CarColors).ThenInclude(x=>x.Color).ToList();
            Car? wanted = cars.FirstOrDefault();
            if (wanted == null)
                throw new NullReferenceException();
            return wanted;
           
        }

        public void Update(int id, Car car)
        {
            Car? wanted = context.Cars.Find(id);
            if (wanted == null)
                throw new NullReferenceException();
            wanted = car;
            context.SaveChanges();

        }
        public void AssignColorToCar(int carId, int colorId)
        {
            Car? car = context.Cars.Find(carId);
            Color? color = context.Colors.Find(colorId);
            if (car == null || color == null)
                throw new NullReferenceException();
            CarColor carColor = new CarColor() { CarId = carId, ColorId=colorId };
            context.CarColors.Add(carColor);
            context.SaveChanges();
        }
    }
}
