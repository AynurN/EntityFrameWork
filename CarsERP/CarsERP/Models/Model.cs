using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId {  get; set; }
        public Brand Brand { get; set; }
        public List<Car> Cars { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Brand.Name}";
        }
    }
}
