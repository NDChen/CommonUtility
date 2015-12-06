using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Common.Logging;
using Common.Components;
using Common.Autofac;
using Common.Log4Net;
using CommonConfig = Common.Configurations.Configuration;

namespace Log4netFileTest
{ 
    class Program
    {
        private static ILogger _logger;

        static void Main(string[] args)
        {
            try
            {
                InitializeCommon();

                string outPrintStringToFile = "Hello World!";

                _logger.Info(outPrintStringToFile);
                _logger.InfoFormat("Test Log4Net interface InfoFormat:{0}", outPrintStringToFile);

                _logger.Warn(outPrintStringToFile);
                _logger.WarnFormat("Test Log4Net interface WarnFormat:{0}", outPrintStringToFile);

                _logger.Error(outPrintStringToFile);
                _logger.ErrorFormat("Test Log4Net interface ErrorFormat:{0}", outPrintStringToFile);

                int testLog4Net = Convert.ToInt32(outPrintStringToFile);
            }
            catch (Exception ex)
            {
                string strTestException = "Test Log4Net Exception.";

                _logger.Error(strTestException, ex);
                _logger.Fatal(strTestException, ex);
            }
        }

        private static void InitializeCommon()
        {
            CommonConfig.Create()
                .UseAutofac()
                .RegisterCommonComponents()
                .UseLog4Net();

            _logger = ObjectContainer.Resolve<ILoggerFactory>().Create(typeof(Program).Name);
        }
    }
}
