using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BLL.Repositories;
using DAL.Models;
using DAL;
namespace BLL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public GiaoVienRepository GiaoViens { get; private set; }
        public HoatDongRepository HoatDongs { get; private set; }
        public HocKyRepository HocKys { get; private set; }
        public KetQuaRepository KetQuas { get; private set; }
        public LopRepository Lops { get; private set; }
        public MonHocRepository MonHocs { get; private set; }
        public QuyenRepository Quyens { get; private set; }
        public SinhVienRepository SinhViens { get; private set; }
        public ThamGiaHoatDongRepository ThamGiaHoatDongs { get; private set; }
        public VaiTroRepository VaiTros { get; private set; }
        public YeuCauRepository YeuCaus { get; private set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            GiaoViens = new GiaoVienRepository(_db);
            HoatDongs = new HoatDongRepository(_db);
            HocKys = new HocKyRepository(_db);
            KetQuas = new KetQuaRepository(_db);
            Lops = new LopRepository(_db);
            MonHocs = new MonHocRepository(_db);
            Quyens = new QuyenRepository(_db);
            SinhViens = new SinhVienRepository(_db);
            ThamGiaHoatDongs = new ThamGiaHoatDongRepository(_db);
            VaiTros = new VaiTroRepository(_db);
            YeuCaus = new YeuCauRepository(_db);
        }

        public async Task<int> Complete()
        {
            return await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
