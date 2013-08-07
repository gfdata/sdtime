using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SD.CWServices.Model.Tickets
{
    [DataContract]
    public class Ticket
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ClientName { get; set; }
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public int TicketID { get; set; }
        [DataMember]
        public string AssignedMember{ get; set; }
        [DataMember]
        public int AssignedMemberId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double HoursBudget { get; set; }
        [DataMember]
        public double HoursActual { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int StatusID { get; set; }

        public override string ToString()
        {
            try
            {

                return string.Format("{0} - {1} ({2})", this.ClientName, this.Title, this.Status);
            }
            catch (Exception )
            {
                return base.ToString();
            }
        }

        public static Ticket CreateTicket(somethingdigital_vTickets ticket)
        {
            Ticket newTicket = new Ticket();
            newTicket.AssignedMember = ticket.Employee;
            newTicket.AssignedMemberId = ticket.employeeId.GetValueOrDefault(0);
            newTicket.ClientID = ticket.clientId.GetValueOrDefault(0);
            newTicket.ClientName = ticket.client;
            newTicket.Description = "";
            newTicket.HoursActual = (double)ticket.actualHours.GetValueOrDefault(0);
            newTicket.HoursBudget = (double)ticket.budget.GetValueOrDefault(0);
            newTicket.TicketID = ticket.ticketid;
            newTicket.Title = ticket.name;
            newTicket.Status = ticket.status;
            newTicket.StatusID = ticket.statusId.GetValueOrDefault(0);
            return newTicket;

        }
    }
}