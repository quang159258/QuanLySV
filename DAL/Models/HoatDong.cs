using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum LoaiHoatDong
    {
        CTXH = 1,
        DRL = 2,
        None=3
    }
    public class HoatDong
    {
        public int Id { get; set; }
        public string TenHoatDong { get; set; } = string.Empty;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string DiaDiem { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int SoLuongThamGia { get; set; } = 0;
        public LoaiHoatDong LoaiHoatDong { get; set; } = LoaiHoatDong.None;
        public int DiemCong { get; set; } = 0;
    }
}
