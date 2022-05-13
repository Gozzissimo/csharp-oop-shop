using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        //private string? Nome;
        //public void SetNome(string s)
        //{
        //    if (s.Length > 10)
        //    {
        //        //voglio limitare il nome a 10 caratteri
        //        Nome = s.Substring(0, 10);
        //    }
        //    else
        //    {
        //        Nome = s;
        //    }
        //}

        //private int Prezzo { get; set; }

        //private double iva;
        //private double Iva
        //{
        //    get { return iva; }
        //    set { if (value != 22.0) Console.WriteLine("Stai mettendo un valore iva non standard!");
        //        iva = value;
        //    }
        //}

        //ATTRIBUTI DICHIARATI
        private int iCodice;
        public string sNome { get; set; }
        public string sDescrizione { get; set; }
        public double dPrezzo { get; set; }
        public int iIva { get; set; }

        
        //GET E SET DI iCodice
        public int GetCodice()
        {
            return this.iCodice;
        }
        private void SetCodice()
        {
            Random myrand = new Random();
            this.iCodice = myrand.Next(1,999999999);
        }
        
        //COSTRUTTORE che richiama la funzione per generare il codice random
        public Prodotto(string sNome, double dPrezzo, string sDescrizione, int iIva)
        {
            this.sNome = sNome;
            this.dPrezzo = dPrezzo;
            this.sDescrizione = sDescrizione;
            this.iIva = iIva;

            SetCodice();
        }

        //METODO PER OTTENERE IL PREZZO IVATO
        public double GetPrezzoIvato()
        {
            return dPrezzo * (iIva * 1.01);
        }

        //METODO PER OTTENERE IL NOME ESTESO (CODICE + NOME)
        public string NomeEsteso()
        {
            return string.Format("{0}-{1}", iCodice, sNome);
        }
    }
}
