using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Tapchi : Document
    {

        public DateTime thangphathanh { get; set; }
        public string sophathanh { get; set; }
        public Tapchi() { }
        public Tapchi(string id, string nxb, int number, String thangphathanh,String sophathanh)
        {
            this.thangphathanh = Utility.ConvertStrignToDateTime(thangphathanh);
            this.sophathanh = Console.ReadLine();
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so phat hanh");
            sophathanh= Console.ReadLine();
            Console.WriteLine("Nhap ngay phat hanh");
            thangphathanh = Utility.ConvertStrignToDateTime();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" ,So phat hanh" + sophathanh + " Ngay phat hanh: " + thangphathanh.ToString());
        }
    }
}
