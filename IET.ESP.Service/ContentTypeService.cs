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
    public class ContentTypeService : IContentTypeService
    {
        private IDataRepositoryFactory _dataFactoryRepository;

        public ContentTypeService(IDataRepositoryFactory dataRepositoryFactory)
        {
            _dataFactoryRepository = dataRepositoryFactory;
        }

        public IList<ContentType> GetContentTypeList()
        {
            IContentTypeRepository contentTypeRepository = _dataFactoryRepository.GetDataRepository<IContentTypeRepository>();
            return contentTypeRepository.Get().ToList();
        }

        public ContentType AddContentType(ContentType contentType)
        {
            IContentTypeRepository contentTypeRepository = _dataFactoryRepository.GetDataRepository<IContentTypeRepository>();
            return contentTypeRepository.Add(contentType);
        }

        public ContentType UpdateContentType(ContentType contentType)
        {
            IContentTypeRepository contentTypeRepository = _dataFactoryRepository.GetDataRepository<IContentTypeRepository>();
            return contentTypeRepository.Update(contentType);
        }
    }
}


