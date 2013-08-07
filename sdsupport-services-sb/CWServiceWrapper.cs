using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using Microsoft.ServiceBus;
using SD.CWServices;

namespace sdsupport
{
    public sealed class CWServiceWrapper
    {
        ServiceHost _host;

        public CWServiceWrapper()
        {
            this.DebugMode = false;
        }

        public void Start()
        {
            var servicePath = ConfigurationManager.AppSettings["ServicePath"];
            var serviceNamespace = ConfigurationManager.AppSettings["ServiceNamespace"];
            var issuerName = ConfigurationManager.AppSettings["IssuerName"];
            var issuerSecret = ConfigurationManager.AppSettings["IssuerSecret"];

            if (this.DebugMode)
            {
                Console.WriteLine("Service Configuration");
                Console.WriteLine("===================================");
                Console.WriteLine("Service Path: {0}", servicePath);
                Console.WriteLine("Service Namespace: {0}", serviceNamespace);
                Console.WriteLine("Issuer Name: {0}", issuerName);
                Console.WriteLine("Issuer Secret: {0}", issuerSecret);
                Console.WriteLine();
            }

            Uri address = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, servicePath);

            if (this.DebugMode)
            {
                Console.WriteLine("Address: {0}", address);
                Console.WriteLine();
            }

            var sharedSecretServiceBusCredential = new TransportClientEndpointBehavior
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret)
            };

            _host = new ServiceHost(typeof(TicketService), address);

            foreach (ServiceEndpoint endpoint in _host.Description.Endpoints)
            {
                endpoint.Behaviors.Add(sharedSecretServiceBusCredential);
            }

            _host.Open();
        }

        public void Stop()
        {
            _host.Close();
        }

        public bool DebugMode { get; set; }
    }
}
