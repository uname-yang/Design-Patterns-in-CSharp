using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class FbWindowsSetting
    {
        public string title { get; set; }

        private List<FunctionButton> functionButtons = new List<FunctionButton>();

        public FbWindowsSetting(string s)
        {
            this.title = s;
        }
        public void addbuttion(FunctionButton fb)
        {
            functionButtons.Add(fb);
        }

        public void removebuttion(FunctionButton fb)
        {
            functionButtons.Remove(fb);
        }

        public void display()
        {
            Console.WriteLine("Display:"+this.title);
            Console.WriteLine("Keys:");
            foreach (var item in functionButtons)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
