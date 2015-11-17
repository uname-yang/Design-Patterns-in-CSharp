using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
 public class ActionNode:AbstractNode
    {
     private string action;

        public ActionNode(string action)
        {
            this.action = action;
        }

        public override string interpret()
        {
            if (action == "move")
            {
                return "MOVE";
            }
            else if (action == "run")
            {
                return "RUN";
            }
            else
            {
                return "NOMEAN";
            }
        }
    }
}
