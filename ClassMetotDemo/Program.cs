using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Erdal";
            musteri1.Soyad = "Genç";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Erdem";
            musteri2.Soyad = "Sercan";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ahsen";
            musteri3.Soyad = "Uyanusta";
            musteri3.Id = 3;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriListeleme(musteri3);
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);

        }
    }
}
