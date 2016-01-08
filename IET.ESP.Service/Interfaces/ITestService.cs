using IET.ESP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IET.ESP.Service.Interfaces
{
    public interface ITestService
    {
        IList<Sale> GetTestList();
        Sale AddTest(Sale Sale);
        Sale UpdateTest(Sale Sale);

        Sale UpdateTest(int Sale);
    }
}
