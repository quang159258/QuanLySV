using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum TinhTrang
    {
        ChuaXuLy = 1,
        DangXuLy = 2,
        DaXuLy = 3
    }
    public class YeuCau
    {
        public int id { get; set; }
        public int MaSV { get; set; }
        public SinhVien SinhVien { get; set; } = new SinhVien();
        public string NoiDung { get; set; } = string.Empty;
        public TinhTrang TinhTrangYeuCau { get; set; } = TinhTrang.ChuaXuLy;
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayXuLy { get; set; } = null;
        public string? GhiChu { get; set; } = null;
        public int GiaoVienId { get; set; }
        public GiaoVien GiaoVien { get; set; } = new GiaoVien();
    }
}
