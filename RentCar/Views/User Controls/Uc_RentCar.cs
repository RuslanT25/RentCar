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
    public partial class Uc_RentCar : UserControl
    {
        readonly ICarRepository _carRepo;
        readonly ICustomerRepository _customerRepo;
        Car _selectedCar;
        double total = 0;
        Uc_CarGetDetail _ucCarGetDetail;
        public Panel PanelCarInfo
        {
            get { return panelCarInfo; }
        }
        public Uc_RentCar(Car car, ICarRepository carRepository, Uc_CarGetDetail uc, ICustomerRepository customerRepository)
        {
            _carRepo = carRepository;
            _customerRepo = customerRepository;
            InitializeComponent();
            _selectedCar = car;
            _ucCarGetDetail = uc;
        }
        public void AddUserControlToPanel(UserControl uc)
        {
            panelCarInfo.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelCarInfo.Controls.Add(uc);
            if (uc is Uc_CarGetDetail carGetDetail)
            {
                carGetDetail.DisplayCarDetails(_selectedCar);
            }
        }
        public void AddExtraGetControlToPanel(Uc_ExtraGet uc)
        {
            uc.CheckBoxCheckedChanged += Uc_CheckBoxCheckedChanged;
            flowLayoutPanel1.Controls.Add(uc);
        }

        private void Uc_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            total += 50;
            lblTotal.Text = total.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            CustomerIsValid(customer);

            _selectedCar.CarStatus = true;
            customer.CarId = _selectedCar.Id;
            customer.Car = _selectedCar;
            customer.Payment = int.Parse(lblTotal.Text);
            customer.CreatedAt = DateTime.Now;
            customer.RentDate = dateTimePicker1.Value;
            customer.ReturnDate = dateTimePicker2.Value;
            double total = double.Parse(lblTotal.Text);
            double price = double.Parse(_ucCarGetDetail.Price);
            customer.Payment = total + price;
            _customerRepo.Add(customer);

            MessageBox.Show("Uğurla icarəyə verildi.");
            this.Hide();
        }

        private void CustomerIsValid(Customer customer)
        {
            List<string> errorMessages = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                customer.Name = txtName.Text;
            }
            else
            {
                errorMessages.Add("Ad daxil edin.");
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                customer.Email = txtEmail.Text;
            }
            else
            {
                errorMessages.Add("Email daxil edin.");
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                customer.Phone = txtPhone.Text;
            }
            else
            {
                errorMessages.Add("Nömrə daxil daxil edin.");
            }

            if (!string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                customer.Surname = txtSurname.Text;
            }
            else
            {
                errorMessages.Add("Soyad daxil edin.");
            }

            if (cbRent.SelectedItem == null)
            {
                errorMessages.Add("Götürəcəyiniz yeri seçin.");
            }
            else
            {
                customer.PickUpLocation = cbRent.SelectedItem.ToString();
            }

            if (cbReturn.SelectedItem == null)
            {
                errorMessages.Add("Qaytaracağınız yeri seçin.");
            }
            else
            {
                customer.DropOffLocation = cbReturn.SelectedItem.ToString();
            }

            if (rbMan.Checked)
            {
                customer.Gender = "Kişi";
            }
            else if (rbWoman.Checked)
            {
                customer.Gender = "Qadın";
            }
            else
            {
                errorMessages.Add("Gender daxil edin.");
            }

            if (errorMessages.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error");
            }
        }

        private void Uc_RentCar_Load(object sender, EventArgs e)
        {
            if (cbRent.Items.Count == 0)
            {
                cbRent.Items.Add("H.Əliyev beynəlxalq hava limanı");
                cbRent.Items.Add("Bakı,İnşaatçılar prospekti 80.");
            }
            if (cbReturn.Items.Count == 0)
            {
                cbReturn.Items.Add("H.Əliyev beynəlxalq hava limanı");
                cbReturn.Items.Add("Bakı,İnşaatçılar prospekti 80.");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
        }
    }
}
