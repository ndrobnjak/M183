﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M183.Models
{
    //Tutorial 14-Logging und Audit Trails
    public class AllUserLoginViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime TimeCreated { get; set; }
        public bool Success { get; set; }
    }
}