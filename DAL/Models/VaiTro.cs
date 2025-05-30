﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class VaiTro
    {
        public int Id { get; set; }
        public string TenVaiTro { get; set; } = string.Empty;
        public ICollection<Quyen> Quyens { get; set; } = new List<Quyen>();
        public ICollection<GiaoVien> GiaoViens { get; set; } = new List<GiaoVien>();
    }
}
