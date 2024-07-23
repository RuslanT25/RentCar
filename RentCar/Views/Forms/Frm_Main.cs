using Autofac;
using AutoMapper;
using Data.Entities;
using RentCar.Customize;
using RentCar.Views.Forms;
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
    public partial class Frm_Main : Form
    {
        readonly IUserRepository _userRepo;
        readonly ICategoryRepository _categoryRepo;
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        readonly ITransmissionRepository _transmissionRepo;
        readonly IExtraRepository _extraRepo;
        readonly IMapper _mapper;
        public Frm_Main(IUserRepository userRepository, ICategoryRepository categoryRepository, ICarRepository carRepository, ICustomerRepository customerRepository, ITransmissionRepository transmissionRepository, IExtraRepository extraRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _categoryRepo = categoryRepository;
            _carRepo = carRepository;
            _customerRepo = customerRepository;
            _transmissionRepo = transmissionRepository;
            _extraRepo = extraRepository;
            _mapper = mapper;
            InitializeComponent();
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbDashboard_Click(object sender, EventArgs e)
        {
            tsbDashboard.Checked = true;
            tsbReturn.Checked = false;

            Uc_Dashboard uc_Dashboard = new Uc_Dashboard(_carRepo, _customerRepo);
            uc_Dashboard.Dock = DockStyle.Fill;
            panelUserControllers.Controls.Clear();
            panelUserControllers.Controls.Add(uc_Dashboard);
            uc_Dashboard.BringToFront();
        }

        private void tsbAdmin_Click(object sender, EventArgs e)
        {
            tsbReturn.Checked = true;
            tsbDashboard.Checked = false;

            Uc_AdminPanel uc_AdminPanel = new Uc_AdminPanel(_userRepo, _categoryRepo, _carRepo, _customerRepo, _transmissionRepo, _extraRepo, _mapper);
            uc_AdminPanel.Dock = DockStyle.Fill;
            panelUserControllers.Controls.Clear();
            panelUserControllers.Controls.Add(uc_AdminPanel);
            uc_AdminPanel.BringToFront();
        }

        public Panel PanelUserControls
        {
            get { return panelUserControllers; }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            string selectedCategory = toolStripMenuItem.Text;

            var carsInCategory = _carRepo.GetCars().Where(c => c.Category.Name == selectedCategory).Where(c => !c.CarStatus);

            Uc_CarsGet uc_CarsGet = new Uc_CarsGet();
            uc_CarsGet.Dock = DockStyle.Fill;
            PanelUserControls.Controls.Clear();
            PanelUserControls.Controls.Add(uc_CarsGet);
            uc_CarsGet.BringToFront();

            FlowLayoutPanel flowLayoutPanelInUcCarsGet = uc_CarsGet.CarsFlowLayoutPanel;

            flowLayoutPanelInUcCarsGet.Controls.Clear();

            foreach (var car in carsInCategory)
            {
                var uc = new Uc_CarPhoto(_carRepo, _extraRepo, this, _customerRepo);
                uc.Name = car.Name;
                uc.Image = Path.Combine(@"D:\RentCar\RentCar\Uploads\cars\", car.Image);
                uc.SelectedCar = car;
                flowLayoutPanelInUcCarsGet.Controls.Add(uc);
            }
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            Frm_Return frmReturn = new Frm_Return(_customerRepo,_mapper);
            frmReturn.Show();
        }
    }
}
