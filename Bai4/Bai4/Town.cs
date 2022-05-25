using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Town : Person
    {
        private List<Town> listHousehold = null;

        public List<Town> ListHousehold { get => listHousehold; set => listHousehold = value; }

    }
}
