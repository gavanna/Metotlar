using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }// veri üzerinde matematiksel işlem yapmadığımız sürece string olarak tanımlamak en doğrusudur. farklı yazılımlara bilgi aktarılması durumunda sorun olmaması için
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
