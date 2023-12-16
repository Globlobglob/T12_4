using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Apartment
    {
        public int flat;
        public int cost;
        public int c;


        public Apartment() { }
        public Apartment(int flat, int cost,int c)
        { 
            this.flat = flat; 
            this.cost =cost; 
            this.c = c;
        }

        public string Cost()
        {
            return $" FLat-{ flat}\n Cost-{Math.Pow(cost,2)}\n S-{c*c} ";
        }


    }
}
