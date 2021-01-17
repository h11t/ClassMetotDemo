using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public ArrayList musteris = new ArrayList { };
        public void Ekle(Musteri musteri)
        {
            musteris.Add(musteri);
            Console.WriteLine(musteri.AdSoyad + " isimli bir müşteri eklenmiştir.");
        }

        public void Listele()
        {
            foreach (Musteri item in musteris)
            {
                Console.WriteLine(item.AdSoyad + " isimli müşterinin hesabı "+ item.HesapTuru +" şeklindedir");
            }
        }

        public void Silme(Musteri musteri)
        {
            musteris.Remove(musteri);
        }
    }
}
