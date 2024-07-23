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

namespace RentCar
{
    public partial class Uc_AdminPanel : UserControl
    {
        readonly IUserRepository _userRepo;
        readonly ICategoryRepository _categoryRepo;
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        readonly ITransmissionRepository _transmissionRepo;
        readonly IExtraRepository _extraRepo;
        readonly IMapper _mapper;
        public Uc_AdminPanel(IUserRepository userRepository, ICategoryRepository categoryRepository, ICarRepository carRepository, ICustomerRepository customerRepository, ITransmissionRepository transmissionRepository, IExtraRepository extraRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _categoryRepo = categoryRepository;
            _carRepo = carRepository;
            _customerRepo = customerRepository;
            _transmissionRepo = transmissionRepository;
            _extraRepo = extraRepository;
            _mapper = mapper;
            InitializeComponent();
        }

        private void pbTransmission_Click(object sender, EventArgs e)
        {
            Uc_Transmission uc_Transmission = new Uc_Transmission(_transmissionRepo, _mapper);
            LoadUserControl(uc_Transmission);
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            Uc_Category uc_Category = new Uc_Category(_categoryRepo, _mapper);
            LoadUserControl(uc_Category);
        }

        private void pbWorker_Click(object sender, EventArgs e)
        {
            Uc_User uc_User = new Uc_User(_userRepo, _mapper);
            LoadUserControl(uc_User);
        }

        private void pbCar_Click(object sender, EventArgs e)
        {
            Uc_CarAdd uc_Car = new Uc_CarAdd(_carRepo, _categoryRepo, _transmissionRepo, _mapper);
            LoadUserControl(uc_Car);
        }
        private void pbExtra_Click(object sender, EventArgs e)
        {
            Uc_ExtraAdd uc_Extra = new Uc_ExtraAdd(_extraRepo, _mapper);
            LoadUserControl(uc_Extra);
        }
        private void LoadUserControl(UserControl userControl)
        {
            int width = userControl.Width;
            int height = userControl.Height;
            userControl.Dock = DockStyle.Fill;
            panelComponents.Width = width;
            panelComponents.Height = height;
            panelComponents.BorderStyle = BorderStyle.FixedSingle;
            panelComponents.Controls.Clear();
            panelComponents.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
