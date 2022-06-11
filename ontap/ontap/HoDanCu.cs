using System;
using System.Collections.Generic;
using System.Text;

namespace ontap
{
    class HoDanCu
    {
        private int soThanhVien;
        private int sonha;
        List<Nguoi> thanhviens;


        public HoDanCu() { }

        public HoDanCu(int soThanhVien,int sonha, List<Nguoi> thanhviens)
        {
            sonha = sonha;
            soThanhVien = soThanhVien;
            thanhviens = thanhviens;
        }

        public int SoThanhVien { get => soThanhVien; set => soThanhVien = value; }
        public int Sonha { get => sonha; set => sonha = value; }
        internal List<Nguoi> Thanhviens { get => thanhviens; set => thanhviens = value; }

        public void Show()
        {
            int i = 1;
            foreach (Nguoi tv in thanhviens)
            {
                Console.WriteLine("nguoi thu: " + i);
                tv.show();
                Console.WriteLine();
                i++;
            }
        }
    }
}
