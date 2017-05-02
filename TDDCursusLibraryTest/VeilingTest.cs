using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void GeenBodHoogsteBodIsNul()
        {
            Assert.AreEqual(decimal.Zero, veiling.hoogsteBod);
        }
        [TestMethod]
        public void EersteBodIsHoogsteBod()
        {
            veiling.DoeBod(1000m);
            Assert.AreEqual(1000m, veiling.hoogsteBod);
        }
        [TestMethod]
        public void MeerdereBodenHoogsteBod()
        {
            veiling.DoeBod(1000m);
            veiling.DoeBod(2000m);
            veiling.DoeBod(1500m);
            Assert.AreEqual(2000m, veiling.hoogsteBod);
        }
    }
}
