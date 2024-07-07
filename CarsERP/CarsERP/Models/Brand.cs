using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsERP.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }

    }
}
