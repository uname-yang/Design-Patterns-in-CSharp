using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class InstructionHandler
    {
        private AbstractNode node;
      //  private string instuction;

        public void handle(string instuction)
        {
            AbstractNode left = null, right = null;
            AbstractNode direction = null, action = null, distance = null;
            Stack<AbstractNode> stack = new Stack<AbstractNode>();
            string[] words = instuction.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "and")
                {
                    left = stack.Pop();
                    string word1 = words[++i];
                    direction = new DirectionNode(word1);
                    string word2 = words[++i];
                    action = new ActionNode(word2);
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);
                    right = new SentenceNode(direction, action, distance);
                    stack.Push(new AndNode(left, right));
                }
                else
                {
                    string word1 = words[i];
                    direction = new DirectionNode(word1);
                    string word2 = words[++i];
                    action = new ActionNode(word2);
                    string word3 = words[++i];
                    distance = new DistanceNode(word3);
                    left = new SentenceNode(direction, action, distance);
                    stack.Push(left);
                }
            }
            this.node = stack.Pop();
        }

        public string output()
        {
            string result = node.interpret();
            return result;
        }
    }
}
