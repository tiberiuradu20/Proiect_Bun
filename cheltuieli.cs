using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT1
{
    class cheltuieli
    {
        private string[] necesitati;
        private int[] sume;
        private static int z = 0;
        private int n;
        public int nr;
        /*public string Afisare_necesitati(int i)
        {
           return necesitati[i];
        }*/
        public cheltuieli()
        {
           /* necesitati = new string[0];
            necesitati[0] = "Memorie nealocata";
            sume = new int[1];
            sume[0] = 0;
            n = 0;
            nr = 0;*/
        }
        public cheltuieli(int nr_)
        {
            nr = nr_;
            necesitati = new string[nr];
            sume = new int[nr];

        }
        public void Adaugare_cheltuiala(string s, int sum)
        {
            necesitati[z] = s;
            sume[z] = sum;
            z++;
        }
        public string[] Lista_Cheltuieli()
        {
            string []s=new string[necesitati.Length];
            for (int i = 0; i < necesitati.Length; i++)
                if(necesitati[i]!=null)
                s[i] = necesitati[i] +' '+Convert.ToString(sume[i]);
              
            
            return s;


        }
        public string Afisare_neces(int i)
        {
            return necesitati[i];
        }
        public int Afisare_suma(int i)
        {
            return sume[i];
        }



    }
}
