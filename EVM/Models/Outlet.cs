using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EVM.Models
{
    public class Outlet
    {
        [Key]
        public int OutletId { get; set; }
        public string Name { get; set; }
    }
}