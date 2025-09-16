using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 person = new Class1("Nguyen Van A", 25, "Ha Noi");
            person.InThongTin();
            Console.ReadLine();
        }
    }
}
