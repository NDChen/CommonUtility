using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4netFileTest
{
    public class LogHelper
    {
        public static void WriteLog(Type t, string msg)
        {
            ILog logger = LogManager.GetLogger(t);
            logger.Error(msg);
        }

        public static void WriteLog(Type t, Exception ex)
        {
            ILog logger = LogManager.GetLogger(t);
            logger.Error("Error", ex);
        }
    }
}
