using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class DirectionNode:AbstractNode
    {
        private string direction;


        public DirectionNode(string direction)
        {
            this.direction = direction;
        }

        public override string interpret()
        {
            if (direction=="up")
            {
                return "UP";
            }
            else if (direction=="down")
            {
                return "DOWN";
            }
            else if (direction == "left")
            {
                return "LEFT";
            }
            else if (direction == "right")
            {
                return "RIGHT";
            }
            else
            {
               return  "NOMEAN";
            }
           
        }
    }
}
