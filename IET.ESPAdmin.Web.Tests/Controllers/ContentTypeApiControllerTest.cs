using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IET.ESP.Service.Interfaces;
using IET.ESPAdmin.Web.Controllers.Api;
using IET.ESP.Model.Entities;
using IET.ESPAdmin.Web.Tests.Specifications;

namespace IET.ESPAdmin.Web.Tests.Controllers
{
    /// <summary>
    /// Summary description for ContentTypeApiControllerTest
    /// </summary>
    [TestClass]
    public class ContentTypeApiControllerTest
    {

        private Mock<IContentTypeService> _mockContentTypeService;
        private ContentTypesController _contentTypesController;
        private readonly ContentTypeList _contentTypeList = new ContentTypeList();

        [TestInitialize]
        public void Setup()
        {
            _mockContentTypeService = new Mock<IContentTypeService>();
            _contentTypesController = new ContentTypesController(_mockContentTypeService.Object);
        }
        

        [TestMethod]
        public void Given_A_List_Of_ContentType_I_Should_Get_ContentType_List()
        {
            //Arrange
            _mockContentTypeService.Setup(d => d.GetContentTypeList()).Returns(_contentTypeList.GetContentTypeListData());
            //Act
            var result = _contentTypesController.Get();
            //Assertf
            Assert.AreEqual(28, result.Count());
        }

        [TestMethod]
        public void Given_A_New_ContentType_I_Should_Get_The_Newly_Created_ContentType_Added_To_ContentType_List()
        {
            //Arrange
            //The New ContentType
            var newContentType = new ContentType { Id = 29, Category = "IET Category", Group = "IET", BookType = "IET1" };
            //Getting the list locally and adding the newly created ContentType
            var contentTypeList = _contentTypeList.GetContentTypeListData();
            contentTypeList.Add(newContentType);
            //Seting up the service to include the newly created ContentType
            _mockContentTypeService.Setup(d => d.AddContentType(newContentType)).Returns(newContentType);
            
            //Act
            //Adding the newly Created ContentType
            var result = _contentTypesController.Post(newContentType);
            //Assert
            //Verifying the Post method was called and the newly created ContentType was added.
            _mockContentTypeService.Verify(d => d.AddContentType(newContentType), Times.Exactly(1));
            Assert.AreEqual(29, contentTypeList.Count());
        }

        [TestMethod]
        public void Given_An_Update_To_The_ContentType_I_Should_Get_See_The_Changes_To_The_ContentType()
        {
            //Arrange
            //The Modifyed ContentType
            var modifiedContentType = new ContentType
            {
                Id = 1,
                Category = "Definitions",
                Group = "Definitions",
                BookType = "IET1"
            };
            
            //Seting up the service to include the modified ContentType
            _mockContentTypeService.Setup(d => d.UpdateContentType(modifiedContentType)).Returns(modifiedContentType);

            //Act
            //Modifying the ContentType
            var result = _contentTypesController.Put(modifiedContentType);
            //Assert
            //Verifying the Put method was called and the changes was made to the ContentType.
            _mockContentTypeService.Verify(d => d.UpdateContentType(modifiedContentType), Times.Exactly(1));
            Assert.AreEqual("IET1", result.BookType);
        }
    }
}
