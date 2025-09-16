using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_github
{
    public class Class1
    {
        private string hoTen;
        private int tuoi;
        private string diaChi;
        public Class1(string hoTen, int tuoi, string diaChi)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Dia chi: " + diaChi);
        }
    }
}
