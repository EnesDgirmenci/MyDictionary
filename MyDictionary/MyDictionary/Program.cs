using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> piece1 = new MyDictionary<string>();
            piece1.Add("Anakart");
            piece1.Add("Ekran");
            piece1.Add("İşlemci");
            piece1.Add("Ekran Kartı");
            piece1.Add("Ram");
            piece1.Add("Soğutucu");
            piece1.Add("Güç Kaynağı");
            piece1.Add("Klavye");
            piece1.Add("kasa");
            Console.WriteLine("Depoda bulunan Pc Parça sayısı: " + piece1.Count);
        }
    }
}
