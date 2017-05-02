using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        private WinstService winstService;
        [TestInitialize]
        public void Initialize()
        {
            opbrengstDAO = new OpbrengstDAOStub();
            kostDAO = new KostDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void BerekenWinst()
        {
            Assert.AreEqual(1084084.78m, winstService.Winst);
        }
    }
}
