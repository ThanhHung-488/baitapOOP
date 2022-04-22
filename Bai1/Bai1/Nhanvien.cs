using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Nhanvien : Canbo
    {
        public String job { get; set; }
        public Nhanvien() { }
        public Nhanvien(String name, String dob, String gendet, String Address, String job) : base(name, dob, gendet, Address)
        {
            this.job = job;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Cong viec: ");
            job = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nhan vien phuc vu: " + job);
        }
    }
}
