using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 3518654.79m;
        }
    }
}