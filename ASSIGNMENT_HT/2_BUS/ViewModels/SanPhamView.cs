﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class SanPhamView
    {
        public Guid Id { get; set; }
        
        public string? Ma { get; set; }
        
        public string? Ten { get; set; }
    }
}
