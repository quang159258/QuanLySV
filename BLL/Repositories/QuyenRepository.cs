using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class QuyenRepository : Repository<Quyen>
    {
        
        public QuyenRepository(AppDbContext db):base(db)
        {
        }
        
    }
}
