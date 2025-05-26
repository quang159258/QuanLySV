using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string TenLop { get; set; } = string.Empty;
        public int SiSo { get; set; }
        public int SiSo { get; set; }
        public int GiaoVienId { get; set; }
        public GiaoVien GiaoVien { get; set; } = new GiaoVien();
        
    }
}
