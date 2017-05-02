using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void WoordIsPalinDroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [TestMethod]
        public void WoordIsGeenPalinDroom()
        {
            Assert.IsFalse(new Woord("karel").IsPalindroom());
        }
    }
}
