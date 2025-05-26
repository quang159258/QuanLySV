using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class HoatDongRepository:Repository<HoatDong>
    {
        public HoatDongRepository(AppDbContext db) : base(db) { }

        
    }
}
