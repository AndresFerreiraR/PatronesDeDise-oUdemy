using BridgePatter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatter.Classes
{
    public abstract class ReaderApp
    {
        public string Text { get; set; }
        protected IDisplayFormatter idisplayFormatter;

        public ReaderApp(IDisplayFormatter _idisplayFormatter)
        {
            this.idisplayFormatter = _idisplayFormatter;
        }

        public abstract void Display();
    }
}
