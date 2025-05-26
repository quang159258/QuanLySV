using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace QuanLySV.Sessions
{
    public static class CurrentUser
    {
        public static GiaoVien LoggedInUser { get; set; }
    }
}
