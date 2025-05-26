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

        public IRepository<GiaoVien> GiaoViens { get;  }
        public IRepository<HoatDong> HoatDongs { get;  }
        public IRepository<HocKy> HocKys { get;  }
        public IRepository<KetQua> KetQuas { get;  }
        public IRepository<Lop> Lops { get;  }
        public IRepository<MonHoc> MonHocs { get;  }
        public IRepository<Quyen> Quyens { get;  }
        public IRepository<SinhVien> SinhViens { get;  }
        public IRepository<ThamGiaHoatDong> ThamGiaHoatDongs { get;  }
        public IRepository<VaiTro> VaiTros { get;  }
        public IRepository<YeuCau> YeuCaus { get;  }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            GiaoViens = new Repository<GiaoVien>(_db);
            HoatDongs = new Repository<HoatDong>(_db);
            HocKys = new Repository<HocKy>(_db);
            KetQuas = new Repository<KetQua>(_db);
            Lops = new Repository<Lop>(_db);
            MonHocs = new Repository<MonHoc>(_db);
            Quyens = new Repository<Quyen>(_db);
            SinhViens = new Repository<SinhVien>(_db);
            ThamGiaHoatDongs = new Repository<ThamGiaHoatDong>(_db);
            VaiTros = new Repository<VaiTro>(_db);
            YeuCaus = new Repository<YeuCau>(_db);
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
