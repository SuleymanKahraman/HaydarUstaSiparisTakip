﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaydarUsta
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string emailAdres { get; set; }
        public string parola { get; set; }
        public string rol { get; internal set; }
    }
}
