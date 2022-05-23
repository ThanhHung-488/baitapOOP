using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Utility
    {
        public static DateTime ConvertStrignToDateTime()
        {
            String c;
            while(true)
            {
                try
                {
                    c = Convert.ToString(Console.ReadLine());
                    DateTime myDate = DateTime.ParseExact(c, "yyyy-MM-dd",
                                      System.Globalization.CultureInfo.InvariantCulture);
                    return myDate;
                }
                catch(System.Exception)
                {
                    Console.WriteLine("Nhap sai, nhap lai!!!");
                }
            }    
        }
        public static DateTime ConvertStrignToDateTime(string c)
        {

            c = Convert.ToString(Console.ReadLine());
            DateTime myDate = DateTime.ParseExact(c, "yyyy-MM-dd",
                               System.Globalization.CultureInfo.InvariantCulture);
            return myDate;

        }
        public static string ConvertDateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static int choose()
        {
            int a;
            while(true)
            {
                try
                {
                    a= int.Parse(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Nhap lai !!!!");
                }
            }    
        }
        public static String chon()
        {
            string a;
            while (true)
                try
                {
                    a = Convert.ToString(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Nhap lai !!!");
                }
        }
        public static void searchByBook()
        {
            
        }
        public static void searchByNewspaper()
        {

        }
        public static void searchByJournal()
        {

        }
    }
}
