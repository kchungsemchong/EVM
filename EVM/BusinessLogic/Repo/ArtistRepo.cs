using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class ArtistRepo : IArtistRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        //private readonly MockData db = new MockData();

        public IEnumerable<Artist> Retrieve()
        {
            var records = db.Artists.ToList();

            return records;
        }

        public Artist Get(int id)
        {
            var record = db.Artists.Where(x => x.ArtistId == id).FirstOrDefault();

            return record;
        }
        public Artist Create(Artist item)
        {
            item.DtAdded = DateTime.UtcNow;
            item.Status = "Active";
            db.Artists.Add(item);
            db.SaveChanges();
            return item;
        }

        public Artist Edit(int id)
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}