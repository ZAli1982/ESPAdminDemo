using IET.ESP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IET.ESP.Service.Interfaces
{
    public interface ISaleService
    {
        IList<Sale> GetSaleList();
        Sale AddSale(Sale Sale);
        Sale UpdateSale(Sale Sale);
    }
}
