using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GiaoVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int MaVaiTro { get; set; }
        public VaiTro VaiTro { get; set; } = new VaiTro();
        public ICollection<Lop> Lops { get; set; } = new List<Lop>(); 
        public ICollection<YeuCau> YeuCaus { get; set; } = new List<YeuCau>();
    }
}
