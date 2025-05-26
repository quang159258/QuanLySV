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

namespace QuanLySV.Views
{
    public partial class LoginPage : Form
    {
        private readonly AuthService _authService;
        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
