using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Town
    {
        private int memberFamily { get; set; }
        List<Family> listFamily = new List<Family>();
        public Town() { }

        public Town(int memberFamily, List<Family> listFamily)
        {
            this.memberFamily = memberFamily;
            this.listFamily = listFamily;
        }
        public void addMemberFamily(Family family)
        {
            listFamily.Add(family);
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap so ho gia dinh:");
            memberFamily = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<memberFamily; i++)
            {
                Console.WriteLine("Nhap so ho gia dinh thu {0}", i + 1);
                Family family = new Family();
                family.InputFamily();
                addMemberFamily(family);
            }    
        }
        public virtual void Display()
        {
            Console.WriteLine("Tong so ho: {0} ", memberFamily);
            for (int i = 0; i < memberFamily; i++)
            {
                Console.WriteLine("Thong tin ho {0}", i + 1);
                listFamily[i].DisplayFamily();
            }
        }

    }
}
