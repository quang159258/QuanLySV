using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.UnitOfWork;
using DAL.Models;
namespace BLL.Services
{
    public class VaiTroService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VaiTroService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<VaiTro>> getVaiTros()
        {
            return (await _unitOfWork.VaiTros.GetAllAsync()).ToList();
        }
        public async Task<List<Quyen>> getQuyens()
        {
            return (await _unitOfWork.Quyens.GetAllAsync()).ToList();
        }
        public async Task<List<Quyen>> getQuyenByVaiTroId(int id)
        {
            return (await _unitOfWork.VaiTros.GetByIdAsync(id)).Quyens.ToList();
        }
        public async Task<bool> CapNhatVaiTro(VaiTro vt, List<int> dsQuyenMoi)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                var vaiTroDb = await _unitOfWork.VaiTros.GetByIdAsync(vt.Id);
                if (vaiTroDb == null) return false;

                var quyenMoi = _unitOfWork.Quyens.Find(q => dsQuyenMoi.Contains(q.Id));
                vaiTroDb.Quyens = quyenMoi.ToList();

                _unitOfWork.VaiTros.Update(vaiTroDb);
                await _unitOfWork.Complete();

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                // Ghi log nếu cần
                return false;
            }
        }

        public async Task<bool> TaoVaiTro(string name, List<string> Quyens)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();

            try
            {
                var existed = _unitOfWork.VaiTros.Find(v => v.TenVaiTro == name);
                if (existed.Any()) return false;

                var vaiTro = new VaiTro
                {
                    TenVaiTro = name,
                    Quyens = new List<Quyen>()
                };

                var quyens = _unitOfWork.Quyens.Find(q => Quyens.Contains(q.TenQuyen));
                vaiTro.Quyens = quyens.ToList();

                await _unitOfWork.VaiTros.AddAsync(vaiTro);
                await _unitOfWork.Complete();

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return false;
            }
        }

    }
}
