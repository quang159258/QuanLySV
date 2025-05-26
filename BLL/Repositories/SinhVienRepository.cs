using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class SinhVienRepository : Repository<SinhVien>
    {
        public SinhVienRepository(AppDbContext db):base(db)
        {
        }
    }
}
