using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class AndNode:AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;

        public AndNode(AbstractNode left, AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        public override string interpret()
        {
            return left.interpret() + " THEN " + right.interpret();
        }
    }
}
