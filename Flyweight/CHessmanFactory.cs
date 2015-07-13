using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class ChessmanFactory
    {
        private static ChessmanFactory instance = null;
        private static List<KeyValuePair<string,Chessman>> kv;

        private ChessmanFactory()
        {
            kv = new List<KeyValuePair<string, Chessman>>();
            Chessman b=new BlackChessman();
            kv.Add(new KeyValuePair<string, Chessman>("b",b) );
            Chessman w = new WhiteChessman();
            kv.Add(new KeyValuePair<string, Chessman>("w", w));
        }

        public static ChessmanFactory getInstance()
        {
            if (instance == null)
            {
                instance = new ChessmanFactory();
            }
            return instance;
        }

        public  Chessman getChessman(string color)
        {
            return kv.Find(p => p.Key == color).Value;
        }
    }
}
