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
    public partial class Uc_Dashboard : UserControl
    {
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        public Uc_Dashboard(ICarRepository carRepository, ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
            _carRepo = carRepository;
            InitializeComponent();
        }

        private void Uc_Dashboard_Load(object sender, EventArgs e)
        {
            lblAvailable.Text = _carRepo.GetAll().Where(x => !x.CarStatus).ToList().Count.ToString();
            lblRented.Text = _carRepo.GetAll().Where(x => x.CarStatus).ToList().Count.ToString();
            lblIncome.Text = _customerRepo.GetAll().Count.ToString();
        }
    }
}
