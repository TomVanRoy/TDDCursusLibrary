using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private WinstService winstService;

        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        
        private Mock<IKostDAO> mockKost;
        private Mock<IOpbrengstDAO> mockOpbrengst;

        [TestInitialize]
        public void Initialize()
        {
            mockKost = new Mock<IKostDAO>();
            mockOpbrengst = new Mock<IOpbrengstDAO>();

            kostDAO = mockKost.Object;
            opbrengstDAO = mockOpbrengst.Object;

            mockKost.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(2500.25m);
            mockOpbrengst.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(3000.75m);
            
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void BerekenWinst()
        {
            Assert.AreEqual(500.50m, winstService.Winst);
            mockOpbrengst.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
            mockKost.Verify(eenKostDAO => eenKostDAO.TotaleKost());
        }
    }
}
