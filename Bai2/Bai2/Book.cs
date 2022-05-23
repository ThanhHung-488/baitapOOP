using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Book : Document
    {
        public String tentacgia { get; set; }
        public int sotrang { get; set; }
        public Book() { }
        public Book(string id, string nxb, int number, string tentacgia, int sotrang)
        {
            this.tentacgia=tentacgia;
            this.sotrang=sotrang;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ten tac gia: ");
            tentacgia = Console.ReadLine();
            Console.WriteLine("Nhap so trang");
            sotrang = Convert.ToInt32(Console.ReadLine().Length);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(", Ten tac gia: "+tentacgia+" So trang",sotrang);
        }
    }
        
    
}
