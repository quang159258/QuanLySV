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
        public int LopId { get; set; }
        public Lop Lop { get; set; } = new Lop();
        public ICollection<ThamGiaHoatDong> ThamGiaHoatDongs { get; set; } = new List<ThamGiaHoatDong>(); 
        public ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
        public ICollection<YeuCau> YeuCaus { get; set; } = new List<YeuCau>();
    }
}
