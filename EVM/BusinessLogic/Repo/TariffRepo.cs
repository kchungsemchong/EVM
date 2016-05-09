using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class TariffRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Tariff> Retrieve()
        {
            //var records = db.Tariffs.ToList();

            //return records;

            return null;
        }

        public Tariff Get(int id)
        {
            //var record = db.Tariffs.Where(x => x.TariffId == id).FirstOrDefault();

            //return record;

            return null;
        }
        public Tariff Create()
        {
            return null;
        }

        public Tariff Edit()
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}