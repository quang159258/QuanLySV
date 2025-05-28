using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using BLL.UnitOfWork;

namespace QuanLySV.Views
{
    public partial class PhanQuyenPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly AuthService _authService;
        private readonly VaiTroService _vaiTroService;
        public PhanQuyenPage(IUnitOfWork unitOfWork, IServiceProvider serviceProvider, AuthService authService, VaiTroService vaiTroService)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _authService = authService;
            _vaiTroService = vaiTroService;
        }

        private void PhanQuyenPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
        }
    }
}
