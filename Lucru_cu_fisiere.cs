using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace PROIECT1
{
    class Lucru_cu_Fisiere
    {
        private string numeFisier;
   
        public Lucru_cu_Fisiere(string numeFisier)
        {
            this.numeFisier = numeFisier;
            /* se incearca deschiderea fisierului in modul OpenOrCreate
            astfel incat sa fie creat daca nu exista */
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public Lucru_cu_Fisiere()
        {

        }
        public void Adaugare_date(venituri venit)
        {
            using (StreamWriter p = new StreamWriter(numeFisier, true))
            {
                p.WriteLine(venit.ConversielaFisier());
            }

        }
        
        public venituri[] GetVenituri(ref int poz)
        {
            string liniefisier;
            poz = 0;
            venituri[] ven = new venituri[100];
            using(StreamReader m=new StreamReader(numeFisier,true))
            {
                while ((liniefisier = m.ReadLine()) != null)
                {
                    ven[poz++] = new venituri(liniefisier);
                }
                liniefisier = m.ReadLine();
            }
            return ven ;
        }


    }
}
