using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectre.Game.Item
{
    public class ItemStack
    {
        public List<Item> itemStack;

        public ItemStack()
        {
            itemStack = new List<Item>();
        }
        public ItemStack(Item item, int amount)
        {
            for (int i = 0; i <= amount; i++)
            {
                itemStack.Add(item.clone());
            }
        }
    }
}
