using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public int LopId { get; set; }
        public Lop Lop { get; set; } = new Lop();
    }
}
