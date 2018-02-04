using practice_c_web_net_01.dao.impl;
using practice_c_web_net_01.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice_c_web_net_01.controllers
{
    public class HomeController : Controller
    {
        private DaoUserImpl daoUserImpl;

        public HomeController()
        {
            daoUserImpl = new DaoUserImpl();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetListUsers()
        {
            return Json( new { data = daoUserImpl.GetListUsers() }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetUserById(int id)
        {
            return Json(new { data = daoUserImpl.GetUserById(id) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult InsertUser(User user)
        {
            return Json(new { data = daoUserImpl.InsertUser(user) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateUser(User user)
        {
            return Json(new { data = daoUserImpl.UpdateUser(user) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteUser(int id)
        {
            return Json(new { data = daoUserImpl.DeleteUser(id) }, JsonRequestBehavior.AllowGet);
        }
    }
}