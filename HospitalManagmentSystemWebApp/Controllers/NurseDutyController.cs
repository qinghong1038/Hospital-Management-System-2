﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalManagmentSystemWebApp.Managers;
using HospitalManagmentSystemWebApp.Models;

namespace HospitalManagmentSystemWebApp.Controllers
{
    public class NurseDutyController : Controller
    {

        private NurseDutyScheduleManager nurseDutyScheduleManager;

        public NurseDutyController()
        {
            nurseDutyScheduleManager = new NurseDutyScheduleManager();
        }
        //-----------------------------------------------------------
        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.nurseList = nurseDutyScheduleManager.GetAllNurse();
            ViewBag.shiftList = nurseDutyScheduleManager.GetAllShift();

            
            return View();
        }
        //-----------------------------------------------------------
        [HttpPost]
        public ActionResult Save(NurseDutyScheduleModel nurseDuty)
        {
            ViewBag.nurseList = nurseDutyScheduleManager.GetAllNurse();
            ViewBag.shiftList = nurseDutyScheduleManager.GetAllShift();
            ViewBag.message = nurseDutyScheduleManager.Save(nurseDuty);

            ModelState.Clear();

            return View();
        }
	}
}