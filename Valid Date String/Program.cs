using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Date_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, p;
            Console.WriteLine("Enter the String: ");
            a = Console.ReadLine();
            p = @"\b(\d{2})(\d{2})(\d{4})\b";
            MatchCollection m = Regex.Matches(a, p);
            foreach (Match match in m)
            {
                string d = match.Value;
                Console.WriteLine(d);
            }
            Console.Read();
        }
    }
}
