using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVM.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public Nullable<DateTime> DtAdded { get; set; }
    }
}