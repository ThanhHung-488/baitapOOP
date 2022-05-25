using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Person
    {
        private object p;

        public String name { get; set; }
        public int age { get; set; }
        public String job { get; set; }
        public String passport { get; set; }
        public Person() { }

        public Person(string name, int age, string job, string passport)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.passport = passport;
        }

        public Person(string name, int age, object p)
        {
            this.name = name;
            this.age = age;
            this.p = p;
        }

        public virtual void Input()
        {
            Console.WriteLine("---Nhap du lieu thong tin thanh vien trong ho gia đinh: ");
            Console.WriteLine("Nhap Ho va ten");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep hien tai: ");
            job = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap CMND: ");
            passport = Convert.ToString(Console.ReadLine());

        }
        public virtual void Display()
        {
            Console.WriteLine("Ho va ten: {0}, Tuoi: {1},Nghe nghiep: {2} ,CMND {3}", name, age, job, passport);
        }

    }
}
