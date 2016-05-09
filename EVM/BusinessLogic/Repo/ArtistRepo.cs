using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class ArtistRepo : IArtistRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

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
        public Artist Create()
        {
            return null;
        }

        public Artist Edit()
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}