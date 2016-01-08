using IET.Common.Interface;
using IET.ESP.Data.Repository.Interface;
using IET.ESP.Model.Entities;
using IET.ESP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace IET.ESP.Service
{
    public class SaleService : ISaleService
    {
        private IDataRepositoryFactory _dataFactoryRepository;

        public SaleService(IDataRepositoryFactory dataRepositoryFactory)
        {
            _dataFactoryRepository = dataRepositoryFactory;
        }

        public IList<Sale> GetSaleList()
        {
            ISaleRepository SaleRepository = _dataFactoryRepository.GetDataRepository<ISaleRepository>();
            return SaleRepository.Get().ToList();
        }

        public Sale AddSale(Sale Sale)
        {
            ISaleRepository SaleRepository = _dataFactoryRepository.GetDataRepository<ISaleRepository>();
            return SaleRepository.Add(Sale);
        }

        public Sale UpdateSale(Sale Sale)
        {
            ISaleRepository SaleRepository = _dataFactoryRepository.GetDataRepository<ISaleRepository>();
            return SaleRepository.Update(Sale);
        }
    }
}


