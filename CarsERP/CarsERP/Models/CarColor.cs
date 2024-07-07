using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Models
{
    public class CarColor
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public  int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
