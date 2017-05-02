using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBodValue;

        public decimal hoogsteBod
        {
            get { return hoogsteBodValue; }
            set
            {
                if (value > hoogsteBodValue)
                {
                    hoogsteBodValue = value;
                }
            }
        }

        public void DoeBod(decimal bedrag)
        {
            hoogsteBod = bedrag;
        }
    }
}
