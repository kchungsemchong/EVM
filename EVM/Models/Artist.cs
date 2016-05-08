using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EVM.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public Nullable<DateTime> DtAdded { get; set; }
        public string FacebookUrl { get; set; }
        public string Status { get; set; }
    }
}