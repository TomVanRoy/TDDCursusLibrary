using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibraryTest
{
    public class Woord
    {
        public Woord(string woord)
        {
            this.woord = woord;
        }
        public readonly string woord;

        public bool IsPalindroom()
        {
            return woord.SequenceEqual(woord.Reverse());
        }
    }
}
