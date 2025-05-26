using DAL;

namespace QuanLySV
{
    public partial class HomePage : Form
    {
        private readonly AppDbContext _context;
        public HomePage(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }
    }
}
