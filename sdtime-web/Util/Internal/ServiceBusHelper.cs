using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Microsoft.ServiceBus;
using SD.CWServices;


namespace sdtime.Util.Internal
{
    public sealed class ServiceBusHelper : IDisposable
    {
        string servicePath;
        string serviceNamespace;
        string issuerName;
        string issuerSecret;

        ChannelFactory<ITicketService> channelFactory;

        public ServiceBusHelper()
        {
            servicePath = ConfigurationManager.AppSettings["ServicePath"];
            serviceNamespace = ConfigurationManager.AppSettings["ServiceNamespace"];
            issuerName = ConfigurationManager.AppSettings["IssuerName"];
            issuerSecret = ConfigurationManager.AppSettings["IssuerSecret"];
        }

        public ITicketService GetService()
        {
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, servicePath);

            TransportClientEndpointBehavior sharedSecretServiceBusCredential = new TransportClientEndpointBehavior();
            sharedSecretServiceBusCredential.TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret);

            channelFactory = new ChannelFactory<ITicketService>("TicketService", new EndpointAddress(serviceUri));

            channelFactory.Endpoint.Behaviors.Add(sharedSecretServiceBusCredential);

            ITicketService channel = channelFactory.CreateChannel();
            Console.WriteLine("Opening Channel.");

            return channel;
        }

        public void Dispose()
        {
            if (channelFactory != null)
            {
                try
                {
                    channelFactory.Close();
                }
                catch (Exception)
                {
                    // do nothing, catch-all
                }
                finally
                {
                    channelFactory = null;
                }
            }
        }
    }
}