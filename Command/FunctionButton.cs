using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class FunctionButton
    {
        public string Name { get; set; }
        private CommandP command;

        public FunctionButton(string s)
        {
            this.Name = s;
        }

        public void  setCommand(CommandP cp)
        {
            this.command = cp;
        }

        public void onclick()
        {
            Console.Write("Clinck:");
            command.execute();
        }
    }
}
