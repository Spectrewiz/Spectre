using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Spectre.Game.Data;

namespace Spectre.Game.Item
{
    public class Item
    {
        private Vector2 space;
        private int value,
            id,
            maxStackAmount;
        private MetaData metaData;

        public Item(int id, int length, int width, int value)
        {
            this.space = new Vector2(length, width);
            this.id = id;
            this.value = value;
        }
        public Item(int id, Vector2 space, int value)
        {
            this.space = space;
            this.id = id;
            this.value = value;
        }

        public static void call(object item)
        {

        }

        public virtual Item clone()
        {
            object clone = this.MemberwiseClone();
            return (Item)clone;
        }
    }
}
