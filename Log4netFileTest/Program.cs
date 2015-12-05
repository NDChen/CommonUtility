using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Log4netFileTest
{ 
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                LogHelper.WriteLog(typeof(Program), "测试log4net");
            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(Program), ex);
            }
            
        }
    }
}
