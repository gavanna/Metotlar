using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac arac1 = new Arac();
            arac1.Marka = "Mercedes";
            arac1.ModelYili = 2020;
            arac1.Model = "A200 Sedan";

            Arac arac2 = new Arac();
            arac2.Marka = "BMW";
            arac2.ModelYili = 2020;
            arac2.Model = "2 GrandCoupe";

            Arac arac3 = new Arac();
            arac3.Marka = "Audi";
            arac3.ModelYili = 2020;
            arac3.Model = "A3 Sedan";

            Arac[] araclar = new Arac[] {arac1,arac2,arac3 };

            Console.WriteLine("------------For Döngüsü Başlıyor------------");
            for (int i = 0; i < araclar.Length; i++)
            {
                Console.WriteLine("Marka = {0}, Model = {1}, Model Yılı = {2}, ", araclar[i].Marka, araclar[i].Model, araclar[i].ModelYili);
            }
            Console.WriteLine("------------For Döngüsü Bitti------------");

            Console.WriteLine("------------Foreach Döngüsü Başlıyor------------");
            foreach (Arac arac in araclar)
            {
                Console.WriteLine("Marka = {0}, Model = {1}, Model Yılı = {2}, ", arac.Marka, arac.Model, arac.ModelYili);
            }
            Console.WriteLine("------------Foreach Döngüsü Bitti------------");


            Console.WriteLine("------------While Döngüsü Başlıyor------------");
            int a = 0;
            while (a < araclar.Length)
            {
                Console.WriteLine("Marka = {0}, Model = {1}, Model Yılı = {2}, ", araclar[a].Marka, araclar[a].Model, araclar[a].ModelYili);
                a++;
            }
            Console.WriteLine("------------While Döngüsü Bitti------------");
        }
    }

    class Arac
    {
        public string Marka { get; set; }
        public int ModelYili { get; set; }
        public string Model { get; set; }

    }
}
