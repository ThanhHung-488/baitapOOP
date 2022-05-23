using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Document
    {
        private String id { get; set; }
        private String nxb { get; set; }
        private int number { get; set; }
        public Document() { }
        public Document(string id, string nxb, int number)
        {
            this.id = id;
            this.nxb = nxb;
            this.number = number;
        }
        public virtual void Input()
        {
            Console.WriteLine("======Nhap du lieu Tai lieu=======");
            Console.WriteLine("Nhap ID tai lieu");
            id = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban: ");
            nxb = Console.ReadLine();
            Console.WriteLine("Nhap so ban phat hanh");
            number = Convert.ToInt32(Console.ReadLine().Length);
        }
        public virtual void Display()
        {
            Console.WriteLine("Id tai lieu: {0} , Nha xuat ban: {1} , So phat hanh: {2} ",id,nxb,number);
        }
    }
}
