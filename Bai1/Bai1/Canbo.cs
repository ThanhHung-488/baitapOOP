using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Canbo
    {
        public String fullName { get; set; }
        public DateTime dob { get; set; }
        public String gender { get; set; }
        public String address { get; set; }

        public Canbo() { }
        public Canbo(String name, String dob, String gendet, String Address)
        {
            this.fullName = name;
            this.dob = Utility.ConvertStrignToDateTime(dob);
            this.gender = gender;
            this.address = Address;
        }

        public virtual void Input()
        {
            Console.WriteLine("=====NHap du lieu Can bo=====");
            Console.WriteLine("Nhap Ho va Ten : ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");


            dob = Utility.ConvertStrignToDateTime();

            Console.WriteLine("Nhap gioi tinh:  ");
            gender = Utility.Gender();
            Console.WriteLine("Nhap dia chi: ");
            address = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.Write("Ho va Ten: {0} , Ngay sinh : {1} , Gioi tinh: {2} , Dia chi: {3}", fullName, dob, gender, address);
        }
    }
}
