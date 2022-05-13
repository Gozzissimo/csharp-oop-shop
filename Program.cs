// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////args è un array/vettore di stringhe
            ////la linea di comando
            ////Eseguire con .\test parametri...
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Parametro {0}: {1}", i, args[i]);
            //}
            ////per provare a fare debug
            //int a = 10;
            //if (a > 20)
            //{
            //    Console.WriteLine("Maggiore di venti");
            //}
            //else
            //{
            //    Console.WriteLine("Minore o uguale a 20");
            //}
            ////le extention per estendere una classe "sealed"
            //Console.WriteLine("pippo pluto paperino".WordCount());
            //Console.WriteLine("Fine");

            /*
             * Esercizio di oggi: C# Shop nome repo: csharp-oop-shop Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
             * Un prodotto è caratterizzato da: - codice (numero intero) - nome - descrizione - prezzo - iva.
             * Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
             * - Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random OK
             * - Il codice prodotto sia accessibile solo in lettura(get)
             * - Gli altri attributi siano accessibili sia in lettura(get) che in scrittura(set)
             * - Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva 
             * - Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome 
             * - Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto. 
             * 
             * BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
             * 
             */

            Prodotto prodotto1 = new Prodotto("Salame", 15.90, "Un buon Salame nostrano IGP", 22);
            Prodotto prodotto2 = new Prodotto("Formaggio", 9.90, "Formaggio d'alpeggio DOP", 10);

            Console.WriteLine("Hai Creato i seguenti Prodotti:");
            Console.WriteLine("Prodotto1: {0}, {1}, {2}", prodotto1.NomeEsteso(), prodotto1.sDescrizione, prodotto1.GetPrezzoIvato());

        }
    }
}




