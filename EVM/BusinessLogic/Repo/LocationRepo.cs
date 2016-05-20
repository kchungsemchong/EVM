using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class LocationRepo : ILocationRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Location> Retrieve()
        {
            var records = db.Locations.ToList();

            return records;
        }
        public Location Get(int id)
        {
            var record = db.Locations.Where(x => x.LocationId == id).FirstOrDefault();

            return record;
        }
        public Location Create(Location item)
        {
            db.Locations.Add(item);
            db.SaveChanges();

            return item;
        }
        public Location Edit()
        {
            return null;
        }
        public bool Delete(int id)
        {
            return true;
        }
    }
}