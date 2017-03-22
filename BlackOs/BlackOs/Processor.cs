using BlackOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOs
{
    class Processor
    {
        ILogger logger = null;
        IMessageSenders messageSender;
        public Processor()
        {
            logger = IocUtil.Resolve<ILogger>();
            messageSender = IocUtil.Resolve<IMessageSenders>();
        }
        public void Process()
        {
            logger.WriteLog("Log Text");
            //Ana Uygulama Akışı             
            messageSender.SendMessage("Message Text");
        }
    }
}
