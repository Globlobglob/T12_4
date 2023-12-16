using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Figures figures = new Figures(56,456);
            //Console.WriteLine(figures.ShowInfo());
            //Console.WriteLine();
            //Figures figures1 = new Figures();
            //Console.WriteLine(figures1.ShowInfo());
            //Console.WriteLine();


            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z= int.Parse(Console.ReadLine());


            //Figures figures3 = new Figures(x,y,z);
            //Console.WriteLine(figures3.ShowInfo());


            Apartment apartment = new Apartment(2,25,65);
            Console.WriteLine($" {apartment.Cost()}");    

            Console.ReadLine();

        }
    }
}
