using IET.ESP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IET.ESP.Service.Interfaces
{
    public interface IContentTypeService
    {
        IList<ContentType> GetContentTypeList();
        ContentType AddContentType(ContentType contentType);
        ContentType UpdateContentType(ContentType contentType);
    }
}
