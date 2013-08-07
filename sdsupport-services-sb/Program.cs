using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace sdsupport
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "/debug")
            {
                var wrapper = new CWServiceWrapper();
                wrapper.DebugMode = true;
                wrapper.Start();

                Console.WriteLine("Service Running in DEBUG MODE");
                Console.WriteLine("Press <Enter> to stop the service");
                Console.ReadLine();

                wrapper.Stop();

            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] 
			    { 
				    new NetRelayService()
			    };
                ServiceBase.Run(ServicesToRun);
            }

        }
    }
}
