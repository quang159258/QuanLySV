using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace DAL.Models
{
    public class GiaoVien
    {
        private static readonly PasswordHasher<GiaoVien> hasher = new PasswordHasher<GiaoVien>();
        private string _matKhau;
        // Ví dụ sử dụng PasswordHasher để mã hóa mật khẩu
        //var result = hasher.VerifyHashedPassword(gv, gv.MatKhau, "123456");
        //if (result == PasswordVerificationResult.Success)
        //{
        //    // Đăng nhập thành công
        //}
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau {
            get => _matKhau;
            set => _matKhau = hasher.HashPassword(this, value);
        }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int MaVaiTro { get; set; }
        public VaiTro VaiTro { get; set; } = new VaiTro();
        public ICollection<Lop> Lops { get; set; } = new List<Lop>(); 
        public ICollection<YeuCau> YeuCaus { get; set; } = new List<YeuCau>();
    }
}
