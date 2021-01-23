using System;

namespace OOP2
{// OOP object oriented programming
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; // Müşteri ile alakası olmamasına karşım bu class'a girilen property'dir.

            // Gerçek Müşteri- Tüzel Müşteri , 2 ayrı nesnemiz var
            // birbirinin yerine kullanılamazlar.
            //SOLID
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "12345678910";
            musteri2.VergiNo = "12345678910";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
}
