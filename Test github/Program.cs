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
            List<Class1> danhSach = new List<Class1>();
            Console.Write("nhap so luong: ");   
            int n = int.Parse(Console.ReadLine());
            for( int i =0; i < n; i++)
            {
                Console.Write("nhap ho ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("nhap tuoi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("nhap dia chi: ");
                string diaChi = Console.ReadLine();
                Class1 sv = new Class1(hoTen, tuoi, diaChi);
                danhSach.Add(sv);
            }
            foreach( Class1 sv in danhSach)
            {
                sv.InThongTin();
            }
        }
    }
}
