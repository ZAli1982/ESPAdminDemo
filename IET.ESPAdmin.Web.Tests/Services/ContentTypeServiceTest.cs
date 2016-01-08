using System;
using IET.Common.Interface;
using IET.ESP.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IET.ESP.Data.Repository.Interface;
using IET.ESPAdmin.Web.Tests.Specifications;
using IET.ESP.Model.Entities;

namespace IET.ESPAdmin.Web.Tests.Services
{
    [TestClass]
    public class ContentTypeServiceTest
    {

        private ContentTypeService _contentTypeService;
        private SaleService _saleService;
        private Mock<IContentTypeRepository> _mockContentTypeRepository;
        private Mock<ISaleRepository> _mockSaleRepository;
        private Mock<IDataRepositoryFactory> _mockDataRepositoryFactory;
        private readonly ContentTypeList _contentTypeList = new ContentTypeList();
        private readonly SalesFakeData _fakeSaleList = new SalesFakeData();

        [TestInitialize]
        public void Setup()
        {
            _mockContentTypeRepository = new Mock<IContentTypeRepository>();
            _mockSaleRepository = new Mock<ISaleRepository>();
            _mockDataRepositoryFactory = new Mock<IDataRepositoryFactory>();
            _contentTypeService = new ContentTypeService(_mockDataRepositoryFactory.Object);
            _saleService = new SaleService(_mockDataRepositoryFactory.Object);
        }

        [TestMethod]
        public void Given_I_Have_A_ContentType_List_When_I_Request_A_List_Of_ContentType_A_ContentType_List_Is_Returned()
        {
            //Arrange
            _mockContentTypeRepository.Setup(d => d.Get()).Returns(_contentTypeList.GetContentTypeListData);
            _mockDataRepositoryFactory.Setup(d => d.GetDataRepository<IContentTypeRepository>()).Returns(_mockContentTypeRepository.Object);
            //Act
            var result = _contentTypeService.GetContentTypeList();
            //Assert
            Assert.AreEqual(28, result.Count);
        }

        [TestMethod]
        public void Given_I_Have_A_New_ContentType_When_I_Post_A_New_ContentType_A_New_ContentType_Should_Be_Created()
        {
            //Arrange
            var newContentType = new ContentType { Id = 29, Category = "IET Category", Group = "IET", BookType = "IET1" };

            _mockContentTypeRepository.Setup(d => d.Add(newContentType)).Returns(newContentType);
            _mockDataRepositoryFactory.Setup(d => d.GetDataRepository<IContentTypeRepository>()).Returns(_mockContentTypeRepository.Object);
            //Act
            var result = _contentTypeService.AddContentType(newContentType);
            //Assert
            _mockContentTypeRepository.Verify(d => d.Add(newContentType), Times.Exactly(1));
            Assert.AreEqual("IET1", result.BookType);
        }

        [TestMethod]
        public void Given_I_Have_A_Update_When_I_Update_A_ContentType_I_Should_See_The_Modified_ContentType()
        {
            //Arrange
            //The Modifyed ContentType
            var modifiedContentType = new ContentType
            {
                Id = 1,
                Category = "Definitions",
                Group = "Definitions",
                BookType = "IET100"
            };

            //Seting up the repository to include the modified ContentType
            _mockContentTypeRepository.Setup(d => d.Update(modifiedContentType)).Returns(modifiedContentType);
            _mockDataRepositoryFactory.Setup(d => d.GetDataRepository<IContentTypeRepository>()).Returns(_mockContentTypeRepository.Object);
            //Act
            //Modifying the ContentType
            var result = _contentTypeService.UpdateContentType(modifiedContentType);
            //Assert
            //Verifying the Put method was called on the Service and the changes was made to the ContentType.
            _mockContentTypeRepository.Verify(d => d.Update(modifiedContentType), Times.Exactly(1));
            Assert.AreEqual("IET100", result.BookType);
        }

        [TestMethod]
        public void Should_Get_SalesList()
        {
            //Arrange
            //SalesRepository
            _mockSaleRepository.Setup(d => d.Get()).Returns(_fakeSaleList.GetSalestData);
            _mockDataRepositoryFactory.Setup(d => d.GetDataRepository<ISaleRepository>()).Returns(_mockSaleRepository.Object);
            //Act
            //Return Sales list
            var result = _saleService.GetSaleList();
            //Assert
            //Check that i get sales list
            Assert.AreEqual(6, result.Count);
        }

        public void Given_A_SalesList_I_Should_Get_SalesList()
        {
            //Arrange
            //SalesRepository
            _mockSaleRepository.Setup(d => d.Get()).Returns(_fakeSaleList.GetSalestData);
            _mockDataRepositoryFactory.Setup(d => d.GetDataRepository<ISaleRepository>()).Returns(_mockSaleRepository.Object);
            //Act
            //Return Sales list
            var result = _saleService.GetSaleList();
            //Assert
            //Check that i get sales list
            Assert.AreEqual(6, result.Count);
        }
    }
}
