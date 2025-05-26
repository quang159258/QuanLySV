using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HocKy
    {
        public int Id { get; set; }
        public string TenHocKy { get; set; } = string.Empty;
        public ICollection<MonHoc> MonHocs { get; set; } = new List<MonHoc>();
    }
}
