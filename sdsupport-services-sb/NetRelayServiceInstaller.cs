using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;

namespace sdsupport
{
    [RunInstaller(true)]
    public partial class NetRelayServiceInstaller : ServiceInstaller
    {
        public NetRelayServiceInstaller()
        {
            InitializeComponent();

            DefineInstallers();
        }

        private void DefineInstallers()
        {
            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller();
            ServiceInstaller serviceInstaller = new ServiceInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            serviceInstaller.ServiceName = "sdsupport";
            serviceInstaller.DisplayName = "SD Support Host Service";
            serviceInstaller.Description = "Hosts an Azure Net Relay WCF service which support sdsupport.apphb.com";

            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    
    }
}
