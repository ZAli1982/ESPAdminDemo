using System.Collections.Generic;
using System.Linq;
using IET.ESP.Data.Repository.Interface;
using IET.ESP.Model.Entities;

namespace IET.ESP.Data.Repository
{
    public class ContentTypeRepository : DataRepositoryBase<ContentType>, IContentTypeRepository
    {
        protected override ContentType AddEntity(ESPContext entityContext, ContentType entity)
        {
           return entityContext.ContentTypeSet.Add(entity);
        }

        protected override ContentType UpdateEntity(ESPContext entityContext, ContentType entity)
        {
            return entityContext.ContentTypeSet.Attach(entity);
        }

        protected override IEnumerable<ContentType> GetEntities(ESPContext entityContext)
        {
            var list = from contentType in entityContext.ContentTypeSet
                select contentType;
            return list.ToList();
        }

        protected override ContentType GetEntity(ESPContext entityContext, int id)
        {
            throw new System.NotImplementedException();
        }

        protected override ContentType GetEntity(ESPContext entityContext, string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
