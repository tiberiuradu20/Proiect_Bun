using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT1
{
    class Program
    {
        static void Main(string[] args)
        {
            venituri v;
            cheltuieli c=new cheltuieli();
            economii e;
            int nr=0, venit_prin, venit_sec,suma,poz=0;
            string optiune;
            string cheltuiala;
            string[] lista;
           
            v = new venituri();
            string numeFisier="venituri";
             v = new venituri(100, 102);
             Lucru_cu_Fisiere fisier = new Lucru_cu_Fisiere(numeFisier);
             ///fisier.Adaugare_date(v);
            /// Console.WriteLine(fisier.GetVenituri());
            do
            {
                Console.WriteLine("a- Specificati nr dvs estimativ de cheltuieli");
                Console.WriteLine("b- Specificati-va venitul");
                Console.WriteLine("c- Afisare venit total");
                Console.WriteLine("d- Adaugare cheltuiala");
                Console.WriteLine("e- Afisare cheltuieli curente");
                Console.WriteLine("f- Salvare venit in fisier");
                Console.WriteLine("g- Citire venit din fisier");
                Console.WriteLine("h- Cautare cheltuiala");
                Console.WriteLine("z- Terminare program");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        Console.Write("nr cheltuielii: ");
                        nr = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        c = new cheltuieli(nr);
                        break;
                    case "B":
                        Console.WriteLine("Specificativa venitul principal");
                        venit_prin = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Specificati suma estimativa a surselor dvs secundare de venit (daca aveti): ");
                        venit_sec = int.Parse(Console.ReadLine());
                        v=new venituri(venit_prin, venit_sec);
                        break;
                    case "C":
                        Console.WriteLine("Venitul dvs total este: ");
                        Console.WriteLine(v.Get_venit_tot());
                        break;
                    case "D":
                        Console.WriteLine("Nume cheltuiala: ");
                        cheltuiala = Console.ReadLine();
                        Console.WriteLine("Suma necesara: ");
                        suma = int.Parse(Console.ReadLine());
                        c.Adaugare_cheltuiala(cheltuiala, suma);
                        nr--;
                        Console.WriteLine($"Mai puteti adauga maxim {nr} cheltuieli");
                        break;
                    case "E":
                        lista = new string[c.nr];
                        lista = c.Lista_Cheltuieli();
                        for (int i = 0; i < c.nr; i++)
                            if (lista[i] != null)
                            {
                                poz = 1;
                                Console.WriteLine(lista[i]);
                            }
                               if(poz==0)
                                Console.WriteLine("Inca nu aveti cheltuieli");
                        break;
                    case "F":
                        fisier.Adaugare_date(v);
                        break;
                    case "G":
                        venituri[] ven = new venituri[100];
                        ven = fisier.GetVenituri(ref poz);
                        Console.WriteLine("Au fost citite urmatoarele venituri:");
                        for (int i = 0; i < poz; i++)
                           Console.WriteLine(ven[i].Get_venit_prin()+ven[i].Get_venit_sec());
                        break;
                    case "H":

                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }


                /*Console.Beep(262,2000);
                Console.WriteLine(Console.ReadLine());*/

                /// Lucru_cu_Fisiere q = new Lucru_cu_Fisiere(s);



            } while (optiune.ToUpper() != "Z");
        }
    }
}
