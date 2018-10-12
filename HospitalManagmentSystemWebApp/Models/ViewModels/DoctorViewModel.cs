﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagmentSystemWebApp.Models.ViewModels
{
    public class DoctorViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string AvailableTime { get; set; }

    }
}