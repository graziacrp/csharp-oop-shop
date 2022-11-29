// See https://aka.ms/new-console-template for more information
using CSharpShop;




Prodotto shop = new Prodotto("Fazzoletti", "doppio velo", 1);
Console.WriteLine("Primo prodotto");
shop.StampaProdotto();


Prodotto shop2 = new Prodotto("Cioccolata", "Cioccolata bicolore", 2);
Console.WriteLine("Secondo prodotto");
shop2.StampaProdotto();

Prodotto shop3 = new Prodotto("Pasta", "Orecchiette", 5.50);
Console.WriteLine("Terzo prodotto");
shop3.StampaProdotto();



