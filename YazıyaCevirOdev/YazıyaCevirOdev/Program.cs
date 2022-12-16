using System;

namespace YazıyaCevirOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a ;
            string s = "";
            string[] BirlerBasamagı = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] OnlarBasamagı = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] YuzlerBasamagı = { "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "YediYüz", "Sekizyüz", "Dokuzyüz" };
            Console.Write("Bir Sayı Giriniz");
            a=int.Parse(Console.ReadLine());
            if (a / 100 >= 1) 
            {
                s += YuzlerBasamagı[(a / 100) - 1];
                a = a % 100;
            }
            if (a / 10 >= 1)
            {
                s += OnlarBasamagı[(a / 10) - 1];

                a = a % 10;
            }
            if (a % 10 != 0)
            {
                s += BirlerBasamagı[(a % 10) - 1];
            }
            Console.WriteLine(s);
            Console.WriteLine("Enter Tuşuna Basınız");
            Console.ReadKey(true);
        }
    }
}
