using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectre.Game.Item.Container
{
    public abstract class Inventory
    {
        private int length,
            width;

        public Inventory()
        {
            length = 14;
            width = 7;
        }
    }
}
