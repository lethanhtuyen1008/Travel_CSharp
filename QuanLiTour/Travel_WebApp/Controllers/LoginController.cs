﻿using BUS_QuanLiTour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_QuanLiTour;

namespace Travel_WebApp.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        BUS_QLNguoiDung nd = new BUS_QLNguoiDung();
        public ActionResult Index()
        {
            return View();
            
        }
        //
        // GET: /Login/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Login/Create

        [HttpPost]
        public ActionResult Create(FormCollection d)
        {
            try
            {
                string name = d["username"];
                string password = d["pwd"];
                if (nd.login(name, password))
                {
                    QL_NguoiDung a = nd.getThongTinND(name, password);
                    Session["user"] = a.Ho + " " + a.Ten;
                    return RedirectToAction("Index", "Tours");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //
        // GET: /Login/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Login/Edit/5

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

        //
        // GET: /Login/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Login/Delete/5

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
