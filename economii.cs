using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT1
{
    class economii
    {
        private int nr_economii;
        economii(int nr_ec = 0)
        {
            nr_economii = nr_ec;
        }
        public int Get_economii()
        {
            return nr_economii;
        }
    }
}
