using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.ESP.Model.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int Sold { get; set; }
        public double Cost { get; set; }
    }
}
