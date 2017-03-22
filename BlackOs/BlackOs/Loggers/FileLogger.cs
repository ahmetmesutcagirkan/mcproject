using BlackOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOs.Loggers
{
    public class FileLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format("FileLogger : {0}", message));
        }
    }
}
