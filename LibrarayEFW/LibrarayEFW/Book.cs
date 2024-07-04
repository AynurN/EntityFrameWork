using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayEFW
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public int GenreId { get; set; }
        public  Genre Genre { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name:{Name}, SalePrice: {SalePrice}, CostPrice:{CostPrice}, Genre:{Genre.Name}";
        }
    }
}
