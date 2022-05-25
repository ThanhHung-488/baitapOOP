using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Family : Person
    {
        public int member { get; set; }
        public String address { get; set; }
        public Family() { }
        public Family(string name, int age, string job, string passport, int member,string address): base(name,age,job,passport)
        {
            base.name = name;
            base.age = age;
            base.job = job;
            base.passport = passport;
            this.member = member;
            this.address = address;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so thanh vien cua gia dinh");
            member = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap dia chi nha");
            address = Console.ReadLine();

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(", So thanh viên: {0}  "+member+"Dia chi nha: {1}",address);
        }
    }
}
