using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.EmlakSample;
namespace CSharpOOP.EmlakSample
{
    public class Villa : Ev
    {
        public Villa(string lokasyon, int OdaSayisi) : base(lokasyon, OdaSayisi)
        {
        }

        public bool HavuzVarmi { get; set; }
        public int BahceAlan { get; set; }
        public int GarajAlan { get; set; }
    }
}
