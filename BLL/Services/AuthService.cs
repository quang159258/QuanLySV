using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.UnitOfWork;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
namespace BLL.Services
{
    public class AuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private static readonly PasswordHasher<GiaoVien> hasher = new PasswordHasher<GiaoVien>();
        public AuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GiaoVien> Login(string username, string password)
        {
            var gv = await _unitOfWork.GiaoViens.GetByUsernameAsync(username);
            if (gv == null)
            {
                throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng.");
            }

            var result = hasher.VerifyHashedPassword(gv, gv.MatKhau, password);
            if (result == PasswordVerificationResult.Success)
            {
                return gv;
            }
            throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng");
        }
        public async Task<GiaoVien> Register(GiaoVien gv)
        {
            var existing = await _unitOfWork.GiaoViens.GetByUsernameAsync(gv.TenDangNhap);
            if (existing != null)
            {
                throw new Exception("Tên đăng nhập đã tồn tại.");
            }
            gv.MatKhau = hasher.HashPassword(gv, gv.MatKhau);
            await _unitOfWork.GiaoViens.AddAsync(gv);
            await _unitOfWork.Complete();

            return gv;
        }
        public async Task<bool> ChangePassword(int giaoVienId, string oldPassword, string newPassword)
        {
            var gv = await _unitOfWork.GiaoViens.GetByIdAsync(giaoVienId);
            if (gv == null)
                return false;

            var result = hasher.VerifyHashedPassword(gv, gv.MatKhau, oldPassword);
            if (result != PasswordVerificationResult.Success)
                return false;

            gv.MatKhau = hasher.HashPassword(gv,newPassword);  
            _unitOfWork.GiaoViens.Update(gv);
            await _unitOfWork.Complete();
            return true;
        }
        public bool HasPermission(GiaoVien gv, string permissionName)
        {
            return gv.VaiTro?.Quyens?.Any(q => q.TenQuyen== permissionName) == true;
        }
        public bool IsInRole(GiaoVien gv, string roleName)
        {
            return gv.VaiTro.TenVaiTro==roleName;
        }
    }
}
