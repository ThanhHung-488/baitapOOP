using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Priority { get; set; }
        public Candidate() { }

        public Candidate(int id, string name, string address, string priority)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Priority = priority;
        }
        public virtual void Input()
        {
            Console.WriteLine("======Nhap du lieu hoc sinh thi tuyen dai hoc/cao dang=====");
            Console.WriteLine("Nhap So Bao Danh");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ho va ten thi sinh");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap dia chi");
            Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap muc uu tien");
            Priority = Ulillity.managerPriority();
        }
        public virtual void Display()
        {
            Console.WriteLine("So bao danh: {0} ," +
                "Ho va ten thi sinh: {1}," +
                "Dia chi: {2}," +
                "Muc do uu tien, {3} " ,Id,Name,Address,Priority);
        }

    }
    
        
}
