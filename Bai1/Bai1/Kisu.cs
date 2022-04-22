using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Kisu : Canbo
    {
        public String work { get; set; }
        public Kisu() { }
        public Kisu(String name, String dob, String gendet, String Address, String job) : base(name, dob, gendet, Address)
        {
            this.work = job;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nganh quan ly: ");
            work = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nganh quan ly: " + work);
        }
    }
}
