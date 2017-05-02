using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        private ISBN ISBNnummer;

        [TestInitialize]
        public void initialize()
        {
            ISBNnummer = new ISBN(9789027439642);
        }

        [TestMethod]
        public void ISBNIs13Cijfers()
        {
            Assert.IsTrue(ISBNnummer.Nummer.ToString().Length == 13);
        }
        [TestMethod]
        public void ISBNIsGeen14CijfersOfMeer()
        {
            Assert.IsFalse(ISBNnummer.Nummer.ToString().Length >= 14);
        }
        [TestMethod]
        public void ISBNIsGeen12CijfersOfMinder()
        {
            Assert.IsFalse(ISBNnummer.Nummer.ToString().Length <= 12);
        }
        [TestMethod]
        public void ISBNControlemechanisme()
        {
            var ISBN = ISBNnummer.Nummer.ToString();
            int som6OnevenPositieGetallen = 0;
            int som6EvenPositieGetallen = 0;

            for (int i = 0; i < ISBN.Length - 1; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    som6EvenPositieGetallen += int.Parse(ISBN[i].ToString());
                }
                else
                {
                    som6OnevenPositieGetallen += int.Parse(ISBN[i].ToString());
                }
            }
            som6EvenPositieGetallen *= 3;

            int som = som6EvenPositieGetallen + som6OnevenPositieGetallen;
            var verschil = (((som / 10) + 1) * 10) - som;

            Assert.AreEqual(int.Parse(ISBN[12].ToString()), verschil);
        }
    }
}
