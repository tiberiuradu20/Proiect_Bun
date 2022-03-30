using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT1
{
    class venituri
    {
        private int venit_principal;
        private int venit_secundar;
        public venituri(int ven_prin = 0, int ven_sec = 0)
        {
            venit_principal = ven_prin;
            venit_secundar = ven_sec;
        }
        public venituri(string linieFisier)
        {
            var date = linieFisier.Split(' ');
            venit_principal = int.Parse(date[0]);
            venit_secundar = int.Parse(date[1]);
        }
        public string ConversielaFisier()
        {
            string b = string.Format("{0}{1}{2}", venit_principal, ' ', venit_secundar);
            return b;
        }
        public int Get_venit_prin()
        {
            return venit_principal;
        }
        public int Get_venit_sec()
        {
            return venit_secundar;
        }
        public int Get_venit_tot()
        {
            return venit_principal + venit_secundar;
        }

    }
}
