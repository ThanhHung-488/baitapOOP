using System;
using System.Collections.Generic;
using System.Text;

namespace ontap
{
    class Nguoi
    {
        private string hoten;
        private int tuoi;
        private string nghenghiep;
        private int cmnd;

        public Nguoi(string hoten, int tuoi, string nghenghiep, int cmnd)
        {
            this.Hoten = hoten;
            this.Tuoi = tuoi;
            this.Nghenghiep = nghenghiep;
            this.Cmnd = cmnd;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public void show()
        {
            Console.WriteLine("Hoten: " + hoten);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Nghe nghiep: " + nghenghiep);
            Console.WriteLine("CMND: " + cmnd);
            Console.WriteLine();
        }
    }

 
}


