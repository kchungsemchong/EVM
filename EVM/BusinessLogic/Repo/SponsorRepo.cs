using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class SponsorRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Sponsor> Retrieve()
        {
            var records = db.Sponsors.ToList();

            return records;
        }

        public Sponsor Get(int id)
        {
            var record = db.Sponsors.Where(x => x.SponsorId == id).FirstOrDefault();

            return record;
        }
        public Sponsor Create()
        {
            return null;
        }

        public Sponsor Edit()
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}