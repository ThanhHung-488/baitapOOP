using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class ManagerCandidate
    {
        private List<Candidate> listCandidate = new List<Candidate>();
        public ManagerCandidate() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi thi sinh");
                Console.WriteLine("2. Hien thi thong tin cua thi sinh va khoi cua thi sinh");
                Console.WriteLine("3. Tim kiem theo So bao danh");
                Console.WriteLine("4. Thoat khoi chuong trinh");
                choose = Ulillity.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        Search();
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
            int number;
            do
            {
                Console.WriteLine("---Chon khoi muon them---");
                Console.WriteLine("1.Khoi A");
                Console.WriteLine("2.Khoi B");
                Console.WriteLine("3.Khoi C");
                Console.WriteLine("4.Thoat");
                int num = Ulillity.choose();
                number = num;
                switch(num)
                {
                    case 1:
                        CandidateA A = new CandidateA();
                        A.Input();
                        listCandidate.Add(A);
                        break;
                    case 2:
                        CandidateB B = new CandidateB();
                        B.Input();
                        listCandidate.Add(B);
                        break;
                    case 3:
                        CandidateC C = new CandidateC();
                        C.Input();
                        listCandidate.Add(C);
                        break;

                }    
            } while(number != 4);   
        }
        public List<Candidate> FindByName(String keyword)
        {
            List<Candidate> searchResult = new List<Candidate>();
            if (listCandidate != null && listCandidate.Count > 0)
            {
                foreach (Candidate sv in listCandidate)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
        public void View()
        {
            if (listCandidate.Count == 0)
            {
                Console.WriteLine("Khong co thi sinh trong danh sach , vui vong them thi sinh");
            }
            for (int i = 0; i < listCandidate.Count; i++)
            {
                listCandidate[i].Display();
            }
        }
        public void Search()
        {

        }

    }
}
