﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class LandDAOStub : ILandDAO
    {
        public Land Read(string landcode)
        {
            return new Land { Landcode = landcode, Oppervlakte = 5 };
        }
        public int OppervlakteAlleLanden()
        {
            return 20;
        }
    }
}