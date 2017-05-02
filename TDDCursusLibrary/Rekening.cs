using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldoValue;
        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }
        }

        public void Storten(decimal bedrag)
        {
            if (bedrag <= decimal.Zero)
            {
                throw new ArgumentException();
            }
            saldoValue += bedrag;
        }
    }
}
