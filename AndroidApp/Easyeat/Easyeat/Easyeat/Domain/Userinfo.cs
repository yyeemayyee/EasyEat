﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Easyeat.Domain
{
    public class Userinfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Gender { get; set; }
        public string Goal { get; set; }
        public string Typeofdiet { get; set; }
    }
}
