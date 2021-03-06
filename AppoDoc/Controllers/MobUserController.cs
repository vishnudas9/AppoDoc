﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppoDoc.Models;
using AppoDoc.Repository;

namespace AppoDoc.Controllers
{
    public class MobUserController : Controller
    {
        // GET: MobUser
        public ActionResult Index()
        {
            return View("MobUser");
        }

        // GET: MobUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MobUser/Create
        public ActionResult Create()
        {
            return View("createMobUser");
        }

        // POST: MobUser/Create
        [HttpPost]
        public ActionResult Create(MobUser mob)
        {
            try
            {

               appuser_repo obj = new appuser_repo();
               var result = obj.New_registration(mob);
                if (result)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    return RedirectToAction("Create");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: MobUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MobUser/Edit/5
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

        // GET: MobUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MobUser/Delete/5
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
