﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        /*public void BiseyYap(int sayi) 
        {
            sayi = 99;
        }*/

        public void Update(Product product)
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

       /* public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
       */
    }
}
