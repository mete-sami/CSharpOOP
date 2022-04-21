using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.EmlakSample
{
    public abstract class Emlak
    {
        public Emlak(string lokasyon,int OdaSayisi):base(lokasyon)
        {
           this.Lokasyon= lokasyon;
        }
        public string Lokasyon { get; set; }
        public int Alan { get; set; }
        public decimal SatisFiyat { get; set; }
        public decimal KiraFiyati { get; set; }
        public decimal SatisVergi {
            get
            {
                return (decimal)SatisFiyat * 0.0012M;
            }
        }
        public decimal KiraVergi
        {
            get
            {
                return (decimal)KiraFiyati * 0.05M;
            }
        }
    }
}
