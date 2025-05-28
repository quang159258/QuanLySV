using BLL.Services;
using BLL.UnitOfWork;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using QuanLySV.Sessions;
using QuanLySV.Views;

namespace QuanLySV
{
    public partial class HomePage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly AuthService _authService;

        public HomePage(IUnitOfWork unitOfWork, IServiceProvider serviceProvider,AuthService authService)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _authService = authService;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            caToolStripMenuItem.Visible = true;
            if (_authService.IsInRole(CurrentUser.LoggedInUser, "PhongDaoTao"))
            {
                caToolStripMenuItem.Visible = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.LoggedInUser = null;
            var login = _serviceProvider.GetRequiredService<LoginPage>();
            this.Hide();
            var result=login.ShowDialog();
            if (result != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PhanQuyenPage= _serviceProvider.GetRequiredService<PhanQuyenPage>();
            PhanQuyenPage.MdiParent = this;
            PhanQuyenPage.Show();
        }
    }
}
