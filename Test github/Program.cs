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
            Class1 person = new Class1("Nguyễn Văn A", 25, "Hà Nội");
            person.InThongTin();
            Console.ReadLine();
        }
    }
}
