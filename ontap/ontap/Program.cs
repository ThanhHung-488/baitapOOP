using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    class Program
    {

        static void Main(string[] args)
        {
            List<HoDanCu> hgd = new List<HoDanCu> { };
            KhuPho khuPho = new KhuPho(hgd);
            Console.WriteLine("Nhap so ho gia dinh: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ho gia dinh thu " + i);
                Console.Write("Nhap so nha: ");
                int sonha = int.Parse(Console.ReadLine());
                Console.Write("Nhap so thanh vien: ");
                int sl = int.Parse(Console.ReadLine());
                khuPho.themHoGiaDinh(sl, sonha);
            }
            Console.WriteLine("===============");
            khuPho.HienThi();

            Console.ReadLine();
        }
 
    }
}
