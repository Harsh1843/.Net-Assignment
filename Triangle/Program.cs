using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int h=int.Parse(Console.ReadLine());
            PT(h);
        }
        static void PT(int h)
        {
            for(int i=1;i<=h;i++) 
            {
                Console.WriteLine(new string(' ',h-i)+ new string('*',2*i-1));
            }
            Console.Read();
        }
    }
}
