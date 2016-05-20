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
    public class ArtistController : Controller
    {
        private readonly IArtistRepo _repo;

        public ArtistController(IArtistRepo repository)
        {
            _repo = repository;
        }

        // GET: Artist
        public ActionResult Index()
        {
            try
            {
                var records = _repo.Retrieve();
                if (records == null)
                    return RedirectToAction("Error404", "Home");

                return View(records);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Artist/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var record = _repo.Get(id);
                if (record == null)
                    return RedirectToAction("Error404", "Home");

                return View(record);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Artist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artist/Create
        [HttpPost]
        public ActionResult Create(Artist item)
        {
            try
            {
                if (String.IsNullOrEmpty(item.Name))
                    return RedirectToAction("Error404", "Home");

                var record = _repo.Create(item);
                if (record.ArtistId < 1)
                    return RedirectToAction("Error404", "Home");

                return RedirectToAction("Index", "Artist");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Artist/Edit/5
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

        // GET: Artist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Artist/Delete/5
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