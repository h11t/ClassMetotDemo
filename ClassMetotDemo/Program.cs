using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri m1 = new Musteri();
            m1.AdSoyad = "Hayrettin Kala";
            m1.HesapTuru = "Vadesiz Mevduat";
            musteriManager.Ekle(m1);

            Musteri m2 = new Musteri();
            m2.AdSoyad = "Saniye Yerli";
            m2.HesapTuru = "Vadesiz Mevduat";
            musteriManager.Ekle(m2);

            Console.WriteLine("--------------------------");
            musteriManager.Listele();

            Console.WriteLine("--------------------------");

            musteriManager.Silme(m1);

            Console.WriteLine("--------------------------");
            musteriManager.Listele();

            Console.WriteLine("--------------------------");
        }
    }
}
