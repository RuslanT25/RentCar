using Autofac;
using AutoMapper;
using Repository.Contracts;

namespace RentCar
{
    public partial class Frm_Login : Form
    {
        readonly IUserRepository _userRepo;
        readonly ICategoryRepository _categoryRepo;
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        readonly ITransmissionRepository _transmissionRepo;
        readonly IExtraRepository _extraRepo;
        readonly IMapper _mapper;
        public Frm_Login(IUserRepository userRepo, ICategoryRepository categoryRepo, ICarRepository carRepo, ICustomerRepository customerRepo, ITransmissionRepository transmissionRepo, IExtraRepository extraRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _categoryRepo = categoryRepo;
            _carRepo = carRepo;
            _customerRepo = customerRepo;
            _transmissionRepo = transmissionRepo;
            _extraRepo = extraRepo;
            _mapper = mapper;
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepo.GetAll().Find(x => x.Email == txtUserName.Text);
            if (user == null)
            {
                MessageBox.Show("Email sehvdir.");
                return;
            }

            var password = _userRepo.GetAll().Find(x => x.Password == txtPassword.Text);
            if (password == null)
            {
                MessageBox.Show("Parol səhvdir.");
                return;
            }

            var form = new Frm_Main(_userRepo, _categoryRepo, _carRepo, _customerRepo, _transmissionRepo, _extraRepo, _mapper);
            form.ShowDialog();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}