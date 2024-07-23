using Autofac;
using AutoMapper;
using RentCar.Views.User_Controls;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IContainer = Autofac.IContainer;

namespace RentCar
{
    public partial class Frm_Loading : Form
    {
        readonly IUserRepository _userRepo;
        readonly ICategoryRepository _categoryRepo;
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        readonly ITransmissionRepository _transmissionRepo;
        readonly IExtraRepository _extraRepo;
        readonly IMapper _mapper;
        public Frm_Loading(IUserRepository userRepo, ICategoryRepository categoryRepo, ICarRepository carRepo, ICustomerRepository customerRepo, ITransmissionRepository transmissionRepo, IExtraRepository extraRepo, IMapper mapper)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if (panel2.Width >= 697)
            {
                timer1.Stop();
                //Application.OpenForms["Frm_Loading"].Close();
                Frm_Login frm_Login = new Frm_Login(_userRepo, _categoryRepo, _carRepo, _customerRepo, _transmissionRepo, _extraRepo, _mapper);
                frm_Login.ShowDialog();
            }
        }

        private void Frm_Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
