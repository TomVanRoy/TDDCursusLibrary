using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class JaarTest // (1)
    {
        [TestMethod] // (2)
        public void EenJaarDeelbaarDoor400IsEenSchrikkeljaar() // (3)
        {
            Assert.IsTrue(new Jaar(2000).IsSchrikkeljaar); // (4)
        }
        [TestMethod]
        public void EenJaarDeelbaarDoor100MaarNietDoor400IsGeenSchrikkeljaar()
        {
            Assert.IsFalse(new Jaar(1900).IsSchrikkeljaar);
        }
        [TestMethod]
        public void EenJaarDeelbaarDoor4IsEenSchrikkeljaar()
        {
            Assert.IsTrue(new Jaar(2012).IsSchrikkeljaar);
        }
        [TestMethod]
        public void EenJaarNietDeelbaarDoor4IsGeenSchrikkeljaar()
        {
            Assert.IsFalse(new Jaar(2015).IsSchrikkeljaar);
        }
    }
}
