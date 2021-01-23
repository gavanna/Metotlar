using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteriEkle)
        {
            Console.WriteLine("Eklenen Müşteri Id {0}, Adı {1}, Soyadı {2}", musteriEkle.Id, musteriEkle.Ad, musteriEkle.Soyad);
        }

        public void MusteriListeleme(Musteri musteriListele)
        {
            Console.WriteLine("Listelenen Müşteri Id {0}, Adı {1}, Soyadı {2}", musteriListele.Id, musteriListele.Ad, musteriListele.Soyad);
        }

        public void MusteriSilme(Musteri musteriSilme)
        {
            Console.WriteLine("Silinen  Müşteri Id {0}, Adı {1}, Soyadı {2}", musteriSilme.Id, musteriSilme.Ad, musteriSilme.Soyad);
        }
    }
}
