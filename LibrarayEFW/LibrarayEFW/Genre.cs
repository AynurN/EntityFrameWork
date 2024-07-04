using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayEFW
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Book> Books { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}";
        }
    } }
