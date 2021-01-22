using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Aybars";
            musteri1.MusteriYasi = 22;
            musteri1.Aciklama = "Kütüphane üyesi";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Oğuzhan";
            musteri2.MusteriYasi = 25;
            musteri2.Aciklama = "Köpek çiftliği var";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Yaşı: " + musteri.MusteriYasi);
                Console.WriteLine("Müşteri Açıklaması: " + musteri.Aciklama);
                Console.WriteLine("------------------------------------------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
