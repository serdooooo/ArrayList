using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kurs_22112021_38_ArrayListGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı (string ) ArrayList içindeki Z-A olacak şekilde sıralayınız
            ArrayList odevListe = new ArrayList();
            odevListe.Add("Fatih");
            odevListe.Add("Esra");
            odevListe.Add("Ali Mert");
            odevListe.Add("Serdar");
            odevListe.Add("Gamze");
            odevListe.Add("Erdem");

            odevListe.Add("Hakan");
            odevListe.Add("Furkan");
            odevListe.Add("Birol");
            odevListe.Add("Cem");
            odevListe.Add("Yakup");
            //tüm değerleri a-z çevir
            odevListe.Sort(); //sıralama
            odevListe.Reverse(); //sıralananı tersten yazdırma.
            foreach (var item in odevListe)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
