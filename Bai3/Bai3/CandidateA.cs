using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CandidateA : Candidate
    {
        public String MON_TOAN = "Toan ";
        public String MON_LY = "Ly ";
        public String MON_HOA = "Hoa ";
        public CandidateA() { }
        public CandidateA(int id, string name, string address, string priority) : base (id, name, address, priority)
        {
            base.Address = address;
            base.Priority = priority;
            base.Name = name;
            base.Id = id;

        }
        public override void Input()
        {
            base.Input();
        }
        public override void Display()
        {
            base.Display();
            string subjectA = String.Concat(MON_LY, MON_HOA, MON_TOAN);
            Console.WriteLine("Subject: " +subjectA);
        }

    }
}
