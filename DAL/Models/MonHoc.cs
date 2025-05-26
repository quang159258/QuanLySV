using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMonHoc { get; set; } = string.Empty;
        public int SoTinChi { get; set; }
        public int HocKyId { get; set; }
        public HocKy HocKyDeXuat { get; set; } = new HocKy();
        public ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
    }
}
