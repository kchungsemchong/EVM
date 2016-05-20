using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EVM.BusinessLogic;
using EVM.Models;

namespace EVM.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepo _repo;

        public LocationController(ILocationRepo repository)
        {
            _repo = repository;
        }

        // GET: Location
        public ActionResult Index()
        {
            try
            {
                if (User.IsInRole("Admin"))
                {
                    var records = _repo.Retrieve();
                    if (records == null)
                        return RedirectToAction("Error404", "Home");

                    return View(records);
                }
                return RedirectToAction("Error404", "Home");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                if (User.IsInRole("Admin"))
                {
                    var records = _repo.Get(id);
                    if (records == null)
                        return RedirectToAction("Error404", "Home");

                    return View(records);
                }

                return RedirectToAction("Error404", "Home");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(Location item)
        {
            try
            {
                if (User.IsInRole("Admin"))
                {
                    if (String.IsNullOrEmpty(item.Name))
                        return RedirectToAction("Error404", "Home");

                    var record = _repo.Create(item);
                    if (record.LocationId < 1)
                        return RedirectToAction("Error404", "Home");

                    return RedirectToAction("Index", "Location");
                }

                return RedirectToAction("Error404", "Home");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}