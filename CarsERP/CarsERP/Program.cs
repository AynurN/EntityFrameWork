using CarsERP.Implementations;
using CarsERP.Interfaces;
using CarsERP.Models;

namespace CarsERP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Brand b1 = new Brand() { Name = "BMW" };
            //IBrandService brand = new BrandService();
            //brand.Create(b1);
          // Model m1=new Model() { Name="F10", BrandId=1};
            IModelService model = new ModelService();
            // model.Create(m1);

            //foreach (var item in model.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
            IColorService color=new ColorService();
            Color c1 = new Color() { Name = "Qara",  };
            Color c2 = new Color() { Name = "Ag" };
            Color c3 = new Color() { Name = "Qirmizi" };
            ICarService carService = new CarService();
            Car c = new Car() { MaxSpeed = 240, FuelTankCapacity = 70, Power = 4, DoorCount = 4, ModelId=1};
            //carService.Create(c);
            //color.Create(c1);
            //color.Create(c2);
            //carService.AssignColorToCar(2, 1);
            //carService.AssignColorToCar(2, 2);
            foreach (var item in carService.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
