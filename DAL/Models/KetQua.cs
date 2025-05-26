using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class KetQua
    {
        public int MaSV { get; set; }
        public SinhVien SinhVien { get; set; } = new SinhVien();
        public int MaMonHoc { get; set; }
        public MonHoc MonHoc { get; set; } = new MonHoc();
        public float HeSoGiuaKy { get; set; }
        public float DiemGiuaKy { get; set; }

        public float HeSoCuoiKy { get; set; }
        public float DiemCuoiKy { get; set; }

        public float DiemTongKet { get; set; }
        public int DiemRenLuyen { get; set; }
    }
}
