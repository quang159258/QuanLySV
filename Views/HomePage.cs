using BLL.UnitOfWork;
using DAL;

namespace QuanLySV
{
    public partial class HomePage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        public HomePage(IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
