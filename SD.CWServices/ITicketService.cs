using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SD.CWServices.Model.Tickets;

namespace SD.CWServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name="ITicketService", Namespace="somethingdigital.com/2013/cwservices")]
    public interface ITicketService
    {
        [OperationContract]
        IEnumerable<Ticket> GetTicketsForAllTime(int?[] members, int?[] clients, int serviceBoard);

        [OperationContract]
        IEnumerable<Ticket> GetTicketsForTheWeek(int?[] members, int?[] clients, int serviceBoard);

        [OperationContract]
        IEnumerable<Status> GetStatus(int serviceBoard);

        [OperationContract]
        bool SetTicket(Ticket ticket);
    }

    public interface ITicketChannel : ITicketService, IClientChannel { }
}
