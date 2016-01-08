using IET.ESP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.ESP.Service
{
    public class TestService : ITestService
    {
        public IList<Model.Entities.Sale> GetTestList()
        {
            throw new NotImplementedException();
        }

        public Model.Entities.Sale AddTest(Model.Entities.Sale Sale)
        {
            throw new NotImplementedException();
        }

        public Model.Entities.Sale UpdateTest(Model.Entities.Sale Sale)
        {
            throw new NotImplementedException();
        }

        public Model.Entities.Sale UpdateTest(int Sale)
        {
            throw new NotImplementedException();
        }
    }
}
