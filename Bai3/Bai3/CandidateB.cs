using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CandidateB : Candidate
    {
        public String MON_TOAN = "Toan";
        public String MON_HOA = "Hoa";
        public String MON_SINH = "Sinh";
        public CandidateB() { }
        public CandidateB(int id, string name, string address, string priority) : base(id, name, address, priority)
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
            string subjectB = String.Concat(MON_TOAN,MON_HOA,MON_SINH);
            Console.WriteLine("Subject: "+ subjectB);
        }

    }
}
