using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Figures
    {
        public int  side1;
        public int side2;
        public int side3;
        public Figures() 
        {
            this.side1 = 4;
            this.side2 = 5;
        
          
        }

        public Figures(int  side1, int side2 )
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public Figures(int side1, int side2, int side3) : this(side1, side2)
        {
           this.side3 = side3;
        }

        public string ShowInfo()
        {
            return $"Side1-{side1}\nSide2-{side2}\nSide3-{side3}\nP-{side1*side2* side3}";
        }

    }
}
