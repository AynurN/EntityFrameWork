using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarColor> CarColors { get; set; }
        public List<Car> Cars { get; set; }
    }
}
