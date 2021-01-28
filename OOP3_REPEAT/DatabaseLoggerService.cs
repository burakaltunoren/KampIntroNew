using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_REPEAT
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
