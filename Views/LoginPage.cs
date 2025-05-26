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
using Microsoft.Extensions.DependencyInjection;
using QuanLySV.Sessions;

namespace QuanLySV.Views
{
    public partial class LoginPage : Form
    {
        private readonly AuthService _authService;
        private readonly IServiceProvider _serviceProvider;
        public LoginPage(AuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Login_ClickAsync(object sender, EventArgs e)
        {
            var username = txt_username.Text.Trim();
            var password = txt_password.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var user = await _authService.Login(username, password); 
                if (user != null)
                {
                    CurrentUser.LoggedInUser = user;
                    var homePage = _serviceProvider.GetRequiredService<HomePage>();
                    //Lấy user đang đăng nhập
                    var u = CurrentUser.LoggedInUser;
                    //
                    this.Hide();
                    homePage.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
