using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class DatabaseLogger:Logger
    {
        public void writelog()
        {
            Console.WriteLine("databaselogger");
        }
    }

    public class FileLogger : Logger
    {
        public void writelog()
        {
            Console.WriteLine("FileLogger");
        }
    }
}
