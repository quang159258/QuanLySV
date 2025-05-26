using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BLL.Repositories;
using DAL.Models;
namespace BLL.UnitOfWork
{
    public interface IUnitOfWork
    {

        IRepository<GiaoVien> GiaoViens { get;  }
        IRepository<HoatDong> HoatDongs { get;  }
        IRepository<HocKy> HocKys { get;  }
        IRepository<KetQua> KetQuas { get;  }
        IRepository<Lop> Lops { get;  }
        IRepository<MonHoc> MonHocs { get;  }
        IRepository<Quyen> Quyens { get;  }
        IRepository<SinhVien> SinhViens { get;  }
        IRepository<ThamGiaHoatDong> ThamGiaHoatDongs { get;  }
        IRepository<VaiTro> VaiTros { get;  }
        IRepository<YeuCau> YeuCaus { get;  }
        Task<int> Complete();
    }
}
