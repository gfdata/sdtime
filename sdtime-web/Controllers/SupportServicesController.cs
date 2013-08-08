using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sdtime.Models.Support;
using sdtime.Models;
using sdtime.Util.Internal;

namespace sdtime.Controllers
{
    public class SupportServicesController : Controller
    {
        //
        // GET: /SupportServices/


        public ActionResult UpdateTicket(Ticket ticket)
        {
            using (var sbh = new ServiceBusHelper())
            {
                var client = sbh.GetService();
                return Json(client.SetTicket(ticket.GetContractObject()));
            }
            
            
            
        }

        public ActionResult ServiceBoard(int?[] members, int?[] clients, int board, bool weekView)
        {
            SupportResponse response = new SupportResponse();

            using (var sbh = new ServiceBusHelper())
            {
                var client = sbh.GetService();

                //var board = sdtime.Util.CWServiceBoards.InteractiveManagedServices;

                IEnumerable<SD.CWServices.Model.Tickets.Ticket> svcTickets = null;

                if (weekView)
                    svcTickets = client.GetTicketsForTheWeek(members, clients, board);
                else
                    svcTickets = client.GetTicketsForAllTime(members, clients, board);
                
                var svcStatus = client.GetStatus(board);

                foreach (var state in svcStatus)
                {
                    response.buckets.Add(new Bucket { name = state.Title, status = state.Title, statusId = state.StatusID, sortOrder = state.SortOrder });
                }
                foreach (var svcTicket in svcTickets)
                {
                    Bucket tmp = response.buckets.FirstOrDefault(b => b.statusId == svcTicket.StatusID);
                    if (tmp != null)
                    {
                        if (!response.members.Any(m => m.memberId == svcTicket.AssignedMemberId))
                            response.members.Add(new Member { fullName = svcTicket.AssignedMember, memberId = svcTicket.AssignedMemberId });
                        if (!response.clients.Any(m => m.clientId == svcTicket.ClientID))
                            response.clients.Add(new Client { clientId = svcTicket.ClientID, clientName = svcTicket.ClientName });

                        tmp.tickets.Add(new Ticket { assigned = svcTicket.AssignedMember, budget = svcTicket.HoursBudget, actual = svcTicket.HoursActual, client = svcTicket.ClientName, description = "", name = svcTicket.Title, number = svcTicket.TicketID, statusId = svcTicket.StatusID });
                    }
                }

                return Json(response, JsonRequestBehavior.AllowGet);
            }
           
            
        }


        public IEnumerable<object> svcStatus { get; set; }
    }
}
