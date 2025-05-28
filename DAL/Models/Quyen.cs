﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Quyen
    {
        public int Id { get; set; }
        public string TenQuyen { get; set; } = string.Empty;
        public ICollection<VaiTro> VaiTros { get; set; } = new List<VaiTro>();
    }
}
