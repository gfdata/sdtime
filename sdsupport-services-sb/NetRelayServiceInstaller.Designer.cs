using System.Diagnostics;
using System.ServiceProcess;
namespace sdsupport
{
    partial class NetRelayServiceInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller();
            ServiceInstaller serviceInstaller = new ServiceInstaller();
            EventLogInstaller logInstaller = new EventLogInstaller();

            logInstaller.Log = "Application";
            logInstaller.Source = "sdsupportsvc";

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            serviceInstaller.ServiceName = "sdsupportsvc";
            serviceInstaller.DisplayName = "SD Support Host Service";
            serviceInstaller.Description = "Hosts an Azure Net Relay WCF service which support sdsupport.apphb.com";

            for (var t = 0; t < Installers.Count; t++)
            {
                if (Installers[t] is EventLogInstaller)
                {
                    Installers.Remove(Installers[t]);
                    break;
                }
            }

            Installers.Add(logInstaller);
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
            
        }

        #endregion
    }
}