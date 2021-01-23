using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet hazır kodlar. tab tab yapınca otomatik kod gelir
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //CRUD Create Read Update Delete
    }
}
