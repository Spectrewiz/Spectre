using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Krypton;
using Krypton.Lights;

namespace Spectre
{
    interface ILightingEngine
    {
        void generateHull();

        void generateLight();
    }
}
