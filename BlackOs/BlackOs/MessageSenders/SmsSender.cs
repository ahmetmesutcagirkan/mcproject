using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOs.Interfaces;

namespace BlackOs.MessageSenders
{
    public class SmsSender : IMessageSenders
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("SmsSender : {0}", message)); ;
        }
    }
}
