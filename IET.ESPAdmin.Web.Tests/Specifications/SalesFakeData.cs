using IET.ESP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.ESPAdmin.Web.Tests.Specifications
{

    public class SalesFakeData
    {
        public List<Sale> GetSalestData()
        {
            return new List<Sale>  
            {
                new Sale { Id = 1,  BookId = 1, BookTitle = "Guidance Note 1: Selection & Erection, 7th Edition", Cost = 12.99, Sold= 1000 },
                new Sale { Id = 2,  BookId = 2, BookTitle = "Guidance Note 7: Special Locations, 5th Edition ", Cost = 22.99, Sold= 10 },
                new Sale { Id = 3,  BookId = 3, BookTitle = "Electrician’s Guide to the Building Regulations (4th Edition)", Cost = 25.00, Sold= 210 },
                new Sale { Id = 4,  BookId = 4, BookTitle = "The City & Guilds Textbook Level 3 NVQ Diploma in Electrotechnical Technology", Cost = 19.00, Sold= 10 },
                new Sale { Id = 5,  BookId = 5, BookTitle = "Code of Practice for In-service Inspection and Testing of Electrical Equipment (4th Edition)", Cost = 45, Sold= 500 },
                new Sale { Id = 6,  BookId = 6, BookTitle = "City and Guilds Textbook Level 2 Diploma Electrical Installations (Buildings and Structures)", Cost = 12.99, Sold= 10 }
            };
        }
    }
}
