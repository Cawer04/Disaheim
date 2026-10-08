using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Utility
    {

        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            return amulet.Quality switch
            {
                Level.Low => 12.5,
                Level.Medium => 20.0,
                Level.High => 27.5,


            };
        }

    }
}
