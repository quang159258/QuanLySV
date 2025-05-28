using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BLL.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Storage;
namespace BLL.UnitOfWork
{
    public interface IUnitOfWork
    {

        GiaoVienRepository GiaoViens { get;  }
        HoatDongRepository HoatDongs { get;  }
        HocKyRepository HocKys { get;  }
        KetQuaRepository KetQuas { get;  }
        LopRepository Lops { get;  }
        MonHocRepository MonHocs { get;  }
        QuyenRepository Quyens { get;  }
        SinhVienRepository SinhViens { get;  }
        ThamGiaHoatDongRepository ThamGiaHoatDongs { get;  }
        VaiTroRepository VaiTros { get;  }
        YeuCauRepository YeuCaus { get;  }
        Task<int> Complete();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();

    }
}
