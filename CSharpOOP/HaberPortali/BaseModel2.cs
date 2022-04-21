using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.HaberPortali
{
    public abstract class BaseModel2
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;


    }
}
