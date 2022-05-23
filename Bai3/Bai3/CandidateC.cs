using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CandidateC : Candidate
    {
        public String MON_VAN = "VAN";
        public String MON_SU = "SU";
        public String MON_DIA = "DIA";
        public CandidateC() { }
        public CandidateC(int id, string name, string address, string priority) : base(id, name, address, priority)
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
            string subjectC = String.Concat(MON_VAN,MON_SU,MON_DIA);
            Console.WriteLine("Subject: "+ subjectC);
        }

    }
}
