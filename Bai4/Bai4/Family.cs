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
        private Person[] listPerson = new Person[10];
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
        public void InputFamily()
        {
            Console.WriteLine("Nhap so thanh vien cua gia dinh");
            member = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap dia chi nha");
            address = Console.ReadLine();
            for(int i= 0; i < this.member; i++)
            {
                Console.WriteLine("Nhap thong tin nguoi thu {0}", i + 1);
                listPerson[i] = new Person();
                listPerson[i].Input();
            }    

        }
        public void DisplayFamily()
        {
            Console.WriteLine(", So thanh viên: {0}  "+member+"Dia chi nha: {1}",address);
            for (int i = 0; i < this.member; i++)
            {
                Console.WriteLine("Thong tin nguoi thu {0}", i + 1);
                listPerson[i].Display();
            }
        }
    }
}
