using BLL.UnitOfWork;
using DAL;

namespace QuanLySV
{
    public partial class HomePage : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomePage(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
