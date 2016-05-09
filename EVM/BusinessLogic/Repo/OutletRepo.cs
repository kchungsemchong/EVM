﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public class OutletRepo
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Outlet> Retrieve()
        {
            var records = db.Outlets.ToList();

            return records;
        }

        public Outlet Get(int id)
        {
            var record = db.Outlets.Where(x => x.OutletId == id).FirstOrDefault();

            return record;
        }
        public Outlet Create()
        {
            return null;
        }

        public Outlet Edit()
        {
            return null;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}