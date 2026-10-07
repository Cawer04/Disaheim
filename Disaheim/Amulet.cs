using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemId;
        public string Design;
        public Level Quality;




        public Amulet(string itemId)
        {

        }
        public Amulet(string itemId, string design)
        {

        }
        public Amulet(string itemId, string design, Level quality)
        {

        }
        public override string ToString()
        {
            return $"itemID: {ItemId}, Design: {Design}, Quality: {Quality}";
        }


    }
}
