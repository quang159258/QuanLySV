using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class VaiTroRepository : Repository<VaiTro>
    {
        public VaiTroRepository(AppDbContext db): base(db)
        {
        }

    }
}
