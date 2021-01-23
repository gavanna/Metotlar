using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string []{"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            // 4 elemanlı bir diziye yeni bir eleman ekleyemeyiz. 
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            int say = 1;
            while (say <= 10)
            {
                Console.WriteLine(say);
                say += 3; // artış miktarı 3 yapılarak çift sayılar elde edilebilir.
            }
            int number = 1000;

            Console.WriteLine("x değeri = x y değeri = y");
            Console.WriteLine("x değeri = {0} y değeri = {1}" + 5 + 10);
            Console.WriteLine("x değeri = {0} y değeri = {1}", 5, 10);
            Console.WriteLine("x değeri = {0} , y değeri = {1}", 5, 10);
        }
    }
}
