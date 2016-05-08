using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EVM.Models
{
    public class Sponsor
    {
        [Key]
        public int SponsorId { get; set; }
        public string Name { get; set; }
        public Nullable<DateTime> DtAdded { get; set; }
    }
}