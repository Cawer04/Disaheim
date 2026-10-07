using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Disaheim
{
    public class Book
    {


        public string ItemId;
        public string Title;
        public double Price;
        

        public Book(string itemId)
        {



        }
        public Book(string itemId, string title)
        {

        }
        public Book (string itemId, string title, double price)
        {

        }
        public override string ToString()
        {

            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";


        }



    }
}
