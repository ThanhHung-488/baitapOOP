using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Bao : Document
    {
        public DateTime ngayphathanh { get; set; }
        public Bao() { }
        public Bao(string id, string nxb, int number,String ngayphathanh)
        {
            this.ngayphathanh = Utility.ConvertStrignToDateTime(ngayphathanh);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nagy phat hanh");
            ngayphathanh = Utility.ConvertStrignToDateTime();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Ngay phat hanh: " +ngayphathanh.ToString());
        }
    }
}
