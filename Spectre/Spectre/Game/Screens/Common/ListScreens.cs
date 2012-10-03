using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Spectre.Game.Screens.Common
{
    /// <summary>
    /// The list screen is a base for other screen classes that are meant to hold data in a list.  For example, the inventory needs a list of all the items.
    /// </summary>
    /// <typeparam name="T">Whatever is going to be in the screen</typeparam>
    public abstract class ListScreen<T> : Screen
    {
    }
}
