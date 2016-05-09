using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class EventRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Event> Retrieve()
        {
            //var records = db.Events.ToList();

            //return records;

            return null;
        }

        public Event Get(int id)
        {
            //var record = db.Events.Where(x => x.EventId == id).FirstOrDefault();

            //return record;

            return null;
        }
        public Event Create()
        {
            return null;
        }

        public Event Edit()
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}