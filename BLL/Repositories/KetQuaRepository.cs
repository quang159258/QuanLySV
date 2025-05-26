using System.Linq.Expressions;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositories
{
    public class KetQuaRepository:Repository<KetQua>
    {
        public KetQuaRepository(AppDbContext db):base(db)
        {
        }
        
    }
}
