using CarsERP.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelTankCapacity { get; set; }
        public int Power { get; set; }
        public int DoorCount { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public List<CarColor> CarColors { get; set; }
        public List<Color> Colors { get; set; }
        
        public override string ToString()
        {
            string colors = string.Empty;
            foreach (var item in CarColors)
            {
                colors += item.Color.Name+ " ";
            }
            return $"{Id} {Model.Brand.Name} {Model.Name} {MaxSpeed} {FuelTankCapacity} {Power} {DoorCount} Colors:{colors}";
        }

    }
}
