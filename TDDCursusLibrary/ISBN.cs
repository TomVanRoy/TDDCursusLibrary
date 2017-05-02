using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        public ISBN(long nummer)
        {
            Nummer = nummer;
        }

        public long Nummer { get; set; }
        
        public override string ToString()
        {
            return "ISBN " + Nummer;
        }
    }
}
