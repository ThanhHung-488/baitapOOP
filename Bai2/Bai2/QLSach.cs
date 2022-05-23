using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class QLSach
    {
        private List<Document> listDocument =new List<Document>();
        public QLSach() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi cho mot tai lieu:Sach,Tap chi,Bao");
                Console.WriteLine("2. TÌm kiem tai lieu theo loai: Sach, Tap chi, Bao");
                Console.WriteLine("3. Hien thi thong tin cua toan bo tai lieu hien co!!!");
                Console.WriteLine("4. Xoa tai lieu muon xoa");
                Console.WriteLine("5. Thoat khoi chuong trinh!!!!");
                choose = Utility.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        Console.WriteLine("a.Tim sach");
                        Console.WriteLine("b.Tim tap chi");
                        Console.WriteLine("c.Tim bao");
                        String chon = Utility.chon();
                        switch(chon)
                        {
                            case "a":
                                {
                                    Utility.searchByBook();
                                    break;
                                }
                            case "b":
                                {
                                    Utility.searchByNewspaper();
                                    break;
                                }
                            case "c":
                                Utility.searchByJournal();
                                break;
                            default:
                                Console.WriteLine("Invalid");
                                break;
                        }    
                        break;
                    case 3:
                        view();
                        break;
                    case 4:
                        delete();
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            }while(choose != 5);
        }

        private void delete()
        {
          
        }

        public void add()
        {
            int num;
            do
            {
                Console.WriteLine("-----Chon tai lieu muon them------");
                Console.WriteLine("1.Sach");
                Console.WriteLine("2.Tap chi");
                Console.WriteLine("3.Bao");
                Console.WriteLine("4.Exit");
                int d = Utility.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        Book sach = new Book();
                        sach.Input();
                        listDocument.Add(sach);
                        break;
                    case 2:
                        Tapchi tc = new Tapchi();
                        tc.Input();
                        listDocument.Add(tc);
                        break;
                    case 3:
                        Bao bao = new Bao();
                        bao.Input();
                        listDocument.Add(bao);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai!!!");
                        break;
                }
            } while (num != 4);
                
        }
        public void view()
        {
            if (listDocument.Count == 0)
            {
                Console.WriteLine("Khong co tai lieu da them");
            }
            for (int i = 0; i < listDocument.Count; i++)
            {
                listDocument[i].Display();
            }
        }
    }
}
