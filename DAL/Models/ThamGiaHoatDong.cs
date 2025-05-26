using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public enum TrangThaiThamGia
    {

        DangKy=0,
        DaThamGia=1,
        KoThamGia=2
    }
    public class ThamGiaHoatDong
    {
        public int MaSV { get; set; }
        public SinhVien SinhVien { get; set; } = new SinhVien();
        public int MaHoatDong { get; set; }
        public HoatDong HoatDong { get; set; } = new HoatDong();
        public TrangThaiThamGia TrangThaiThamGia { get; set; } = TrangThaiThamGia.DangKy;
    }
}
