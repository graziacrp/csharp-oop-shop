using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        //Proprietà
        {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double Iva;

        //Costruttori (codice visibile solo in lettura)
        public Prodotto (int codice, string nome, string descrizione, double prezzo, double Iva  )
        {
            //this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.Iva = Iva;
        }

        public double GetCodiceProdotto()
        {
            double codice;
            Random random = new Random();
            codice = random.Next(20, 20000);
            return codice;
        }

        public double IvaProdotto ()
        {
            double Iva;
            Iva = prezzo * 1.22;
            return Iva;
        }

        public void StampaProdotto ()

            Console.WriteLine("Il codice del prodotto è:" + nome +  getCodiceProdotto ());
            Console.WriteLine("Il nome del prodotto è:" + nome);
        Console.WriteLine ("Descrizione del prodotto è" + descrizione);
            Console.WriteLine("Il prezzo del prodotto è" + prezzo + €);
            Console.WriteLine("L'Iva del prodotto è" + Iva ());
}





   