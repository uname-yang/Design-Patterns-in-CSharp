using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class MinCommand:CommandP
    {
        private MinHander mm;
        public MinCommand()
        {
            mm = new MinHander();
        }

        public override  void execute()
        {
            mm.mininize();
        }
    }
}
