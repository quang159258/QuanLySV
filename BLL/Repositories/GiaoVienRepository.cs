using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class GiaoVienRepository: Repository<GiaoVien>
    {
        public GiaoVienRepository(AppDbContext context) : base(context) { }

        public async Task<GiaoVien> GetByUsernameAsync(string username)
        {
            return await dbSet
                .Include(g => g.VaiTro)
                    .ThenInclude(vt => vt.Quyens)
                .FirstOrDefaultAsync(g => g.TenDangNhap == username);
        }
    }
}
