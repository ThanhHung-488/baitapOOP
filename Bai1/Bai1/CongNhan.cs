using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CongNhan : Canbo
    {
        public int level { get; set; }
        public CongNhan() { }
        public CongNhan(String name, String dob, String gendet, String Address, int level) : base(name, dob, gendet, Address)
        {
            this.level = level;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap cap bac: ");
            level = Utility.Level();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Cap Bac: " + level + "/7");
        }
    }
}
