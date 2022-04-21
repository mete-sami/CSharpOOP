using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Rent;
namespace CSharpOOP.Rent
{
    public abstract class Vehicle
    {
        public int Id { get; set; }

        public Brand Brand { get; set; }
        public int ReleaseYear { get; set; }

        protected virtual class CalcVisaDate(int gg){
            

        }


    }
}
