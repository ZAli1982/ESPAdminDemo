using IET.ESP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IET.ESP.Service.Interfaces;

namespace IET.ESPAdmin.Web.Controllers.Api
{
    public class ContentTypesController : ApiController
    {
        private IContentTypeService _contentTypeService;

        public ContentTypesController(IContentTypeService contentTypeService)
        {
            _contentTypeService = contentTypeService;
        }
        // GET api/<controller>
        public IEnumerable<ContentType> Get()
        {
            IList<ContentType> contentTypeList = _contentTypeService.GetContentTypeList();
            return contentTypeList;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public ContentType Post([FromBody]ContentType contentType)
        {
            return _contentTypeService.AddContentType(contentType);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public ContentType Put([FromBody]ContentType contentType)
        {
            return _contentTypeService.UpdateContentType(contentType);
            //return new ContentType{BookType = "NewBookType", Id = 99, Category = "New Category", Group = "New Group"};
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}