using Data.Entities;
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

namespace RentCar.Views.User_Controls
{
    public partial class Uc_CarPhoto : UserControl
    {
        readonly ICarRepository _carRepo;
        readonly IExtraRepository _extraRepo;
        readonly ICustomerRepository _customerRepo;
        readonly Frm_Main _frmMain;
        public Uc_CarPhoto(ICarRepository carRepository, IExtraRepository extraRepo, Frm_Main frmMain, ICustomerRepository customerRepo)
        {
            _carRepo = carRepository;
            InitializeComponent();
            _extraRepo = extraRepo;
            _frmMain = frmMain;
            _customerRepo = customerRepo;
        }

        public string Image
        {
            get { return pictureBox2.ImageLocation; }
            set { pictureBox2.ImageLocation = value; }
        }

        public string Name
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public Car SelectedCar { get; set; }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (SelectedCar == null)
            {
                MessageBox.Show("Zehmet olmasa bir maşın seçin.");
                return;
            }

            Uc_CarGetDetail carDetailControl = new Uc_CarGetDetail(_carRepo, SelectedCar);
            Uc_RentCar uc_RentCar = new Uc_RentCar(SelectedCar, _carRepo, carDetailControl, _customerRepo);
            uc_RentCar.AddUserControlToPanel(carDetailControl);
            var extras = _extraRepo.GetAll();
            foreach (var extra in extras)
            {
                Uc_ExtraGet extraGetControl = new Uc_ExtraGet(extra);
                uc_RentCar.AddExtraGetControlToPanel(extraGetControl);
            }

            uc_RentCar.Dock = DockStyle.Fill;
            _frmMain.PanelUserControls.Controls.Clear();
            _frmMain.PanelUserControls.Controls.Add(uc_RentCar);
            uc_RentCar.BringToFront();
        }
    }
}
