using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class HelpCommand:CommandP
    {
        private HelpHander hh;
        public HelpCommand()
        {
            hh = new HelpHander();
        }

        public override void execute()
        {
            hh.display();
        }

    }
}
