using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QLCB
    {
        private List<Canbo> listCanbo = new List<Canbo>();
        public QLCB() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi cho can bo");
                Console.WriteLine("2. Tim kiem theo ho va ten");
                Console.WriteLine("3. Hien thi thong tin cua toan can bo");
                Console.WriteLine("4. Thoat");
                choose = Utility.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose != 4);
        }

        public void add()
        {
            int num;
            do
            {
                Console.WriteLine("===Chon vi tri muon them===");
                Console.WriteLine("1.Nhan vien");
                Console.WriteLine("2.Ki Su");
                Console.WriteLine("3.Cong nhan");
                Console.WriteLine("4.Thoat");
                int d = Utility.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        Nhanvien nv = new Nhanvien();
                        nv.Input();
                        listCanbo.Add(nv);

                        break;
                    case 2:

                        Kisu ks = new Kisu();
                        ks.Input();
                        listCanbo.Add(ks);

                        break;
                    case 3:

                        CongNhan cn = new CongNhan();
                        cn.Input();
                        listCanbo.Add(cn);

                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!");
                        break;
                }
            } while (num != 4);
        }
        public void search()
        {
            Console.WriteLine("Nhap ten can bo can tim: ");
            String name = Console.ReadLine();
            for (int i = 0; i < listCanbo.Count; i++)
            {
                if (listCanbo[i].fullName.Equals(name))
                {
                    listCanbo[i].Display();
                }
            }
        }
        public void View()
        {
            if (listCanbo.Count == 0)
            {
                Console.WriteLine("Khong co can bo trong danh sach , vui vong them can bo");
            }
            for (int i = 0; i < listCanbo.Count; i++)
            {
                listCanbo[i].Display();
            }
        }
    }
}
