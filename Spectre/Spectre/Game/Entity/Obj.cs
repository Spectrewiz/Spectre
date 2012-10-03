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

/// <summary>
/// An entity is any object inside of the game that has to do with the game.  
/// </summary>
namespace Spectre.Game.Entity
{
    /// <summary>
    /// This class serves as a base for all objects in the game.  
    /// </summary>
    public abstract class Obj
    {
        public Obj(int pos)
        {

        }

        public virtual void Initialize()
        {

        }

        public virtual void LoadContent(ContentManager content)
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        public virtual void generateLight()
        {

        }

        public virtual void generateHull()
        {

        }
    }
}
