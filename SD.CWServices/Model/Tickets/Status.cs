using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SD.CWServices.Model.Tickets
{
    [DataContract]
    public class Status
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int StatusID { get; set; }
        [DataMember]
        public int SortOrder { get; set; }

        public static Status CreateStatus (SR_Status status) {
            Status newStatus = new Status();
            newStatus.StatusID = status.SR_Status_RecID;
            newStatus.Title = status.Description;
            newStatus.SortOrder = status.Sort_Order.GetValueOrDefault(0);
            return newStatus;
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}