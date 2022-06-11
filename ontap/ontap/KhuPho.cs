using System;
using System.Collections.Generic;
using System.Text;

namespace ontap
{
    class KhuPho
    {
        private List<HoDanCu> khuphos;
        public KhuPho(List<HoDanCu> khupho)
        {
            khupho = khupho;

        }
        public List<HoDanCu> Khupho { get => khuphos; set => khuphos = value; }
        public void themThanhVien(HoDanCu hgd)
        {
            Console.WriteLine("ho ten: ");
            string ht = Console.ReadLine();
            Console.WriteLine("tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nghe nghiep: ");
            string nn = Console.ReadLine();
            Console.WriteLine("CMND: ");
            int cmnd = int.Parse(Console.ReadLine());

            Nguoi tv = new Nguoi(ht, tuoi, nn, cmnd);
            hgd.Thanhviens.Add(tv);
        }

        public void themHoGiaDinh(int n,int sonha)
        {
            List<Nguoi> tvm = new List<Nguoi> { };
            HoDanCu hgd = new HoDanCu( n,sonha, tvm);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Thanh vien thu: " + 1);
                themThanhVien(hgd);
            }
            Khupho.Add(hgd);
        }
        public void HienThi()
        {
            int i = 1;
            foreach(HoDanCu hdg in Khupho)
            {
                Console.WriteLine("Ho gia dinh thu: " + i);
                hdg.Show();
                i++;
            }
        }
    }
}
