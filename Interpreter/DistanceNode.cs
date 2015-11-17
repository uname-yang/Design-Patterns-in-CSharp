using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
 public class DistanceNode:AbstractNode
    {
     private string distance;

     public DistanceNode(string distance)
        {
            this.distance = distance;
        }

     public override string interpret()
        {
            return this.distance;
        }
    }
}
