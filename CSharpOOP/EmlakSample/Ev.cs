using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.EmlakSample;

namespace CSharpOOP.EmlakSample
{
    public class Ev :Emlak
    {
        public Ev(string lokasyon , int OdaSayisi): base(lokasyon)
        {
            
        }
        public int OdaSayisi { get; set; }
        public int Kat { get; set; }
        public bool banyoVarmi {
            get
            {
                return banyoVarmi;
            }
        }
        public bool LuksMu { get; set; }
    }
}
