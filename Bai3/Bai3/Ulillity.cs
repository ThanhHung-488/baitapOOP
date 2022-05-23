using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Ulillity
    {
        public static String managerPriority()
        {
            Console.WriteLine("1. Nhom uu tien 1");
            Console.WriteLine("2. Nhom uu tien 2");
            Console.WriteLine("3. Khu vuc 1");

            Console.WriteLine("3. Khu vuc 2-NT");
            Console.WriteLine("3. Khu vuc 2");
            Console.WriteLine("3. Khu vuc 3");
            int d;
            do
            {
                while (true)
                {
                    try
                    {
                        d = int.Parse(Console.ReadLine());
                        switch (d)
                        {
                            case 1:
                                return "Nhóm ưu tiên 1: được cộng 2 điểm";
                                break;
                            case 2:
                                return "Nhóm ưu tiên 2: được cộng 1 điểm";
                                break;
                            case 3:
                                return "Khu vực 1: được cộng 0,75 điểm";
                                break;
                            case 4:
                                return "Khu vực 2 - NT: được cộng 0,5 điểm ";
                                break;
                            case 5:
                                return "Khu vực 2: được cộng 0,25 điểm ";
                                break;
                            case 6:
                                return "Khu vực 3: không được cộng điểm ưu tiên";
                                break;
                            default:
                                Console.WriteLine("Lua chon lai");
                                break;
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Nhap lai!!");
                    }
                }
            } while (d != 1 || d != 2 || d != 3 || d != 4 || d != 5 || d != 6);

        }
        public static int choose()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
    }
}
