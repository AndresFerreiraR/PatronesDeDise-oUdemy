﻿using BridgePatter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatter.Classes
{
    public class Windows10 : ReaderApp
    {
        public Windows10(IDisplayFormatter _idisplayFormatter) : base(_idisplayFormatter)
        {
        }

        public override void Display()
        {
            idisplayFormatter.Display("Aplicacion utilizada en Windows 10" + Text);
        }
    }
}
