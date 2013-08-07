using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace sdsupport
{
    partial class NetRelayService : ServiceBase
    {
        CWServiceWrapper wrapper = new CWServiceWrapper();

        public NetRelayService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            wrapper.Start();    
        }

        protected override void OnStop()
        {
            wrapper.Stop();
        }
    }
}
