using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Utility
    {
        public static void LimitCMND(string passport)
        {
            String passport;
            while (true)
            {
                try
                {
                    passport = Convert.ToString(Console.ReadLine());
                    int sizeOfArray = passport.Length;
                    if (sizeOfArray > 9 && sizeOfArray < 0)
                    {
                        Console.WriteLine("Ban nhap so CMND chua dung!!! Moi nhap lai");
                    }
                    else
                        Console.WriteLine("CMND: {0}", passport);
                }catch(System.Exception)
                {
                    Console.WriteLine("EROR");
                }

            }    
        //    String[] passport = new string[] { "TRUE", "FALSE" };
        //    int sizeOfArray = passport.Length;
        //    if(sizeOfArray > 9)
        //    {
        //        Console.WriteLine("Ban nhap so CMND chua dung!!! Moi nhap lai");
        //    }  
        //    else
        //        Console.WriteLine("CMND: {0}", passport)

        }
    }
}
