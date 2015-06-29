using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
     public class DatabaseFactory:LoggerFactory
    {
         public Logger createLogger()
         {
             Logger logger = new DatabaseLogger();
             return logger;
         }
    }

     public class FileFactory : LoggerFactory
     {
         public Logger createLogger()
         {
             Logger logger = new FileLogger();
             return logger;
         }
     }

}
