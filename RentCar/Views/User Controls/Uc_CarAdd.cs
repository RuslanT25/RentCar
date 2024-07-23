using AutoMapper;
using Data.DTOs.CarDTO;
using Data.DTOs.UserDTO;
using Data.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Views.User_Controls
{
    public partial class Uc_CarAdd : UserControl
    {
        readonly ICarRepository _carRepo;
        readonly ICategoryRepository _categoryRepo;
        ITransmissionRepository _transmissionRepository;
        readonly IMapper _mapper;
        public Uc_CarAdd(ICarRepository carRepository, ICategoryRepository categoryRepo, ITransmissionRepository transmissionRepository, IMapper mapper)
        {
            _carRepo = carRepository;
            _mapper = mapper;
            _categoryRepo = categoryRepo;
            _transmissionRepository = transmissionRepository;
            InitializeComponent();
        }

        private void Uc_CarAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["Name"].Value != null)
                {
                    txtName.Text = row.Cells["Name"].Value.ToString();
                }

                if (row.Cells["Category"].Value != null)
                {
                    cbCategory.SelectedIndex = cbCategory.FindString(row.Cells["Category"].Value.ToString());
                }

                if (row.Cells["Passanger"].Value != null)
                {
                    decimal passengerValue;
                    if (decimal.TryParse(row.Cells["Passanger"].Value.ToString(), out passengerValue))
                    {
                        numPassenger.Value = passengerValue;
                    }
                }

                if (row.Cells["Transmission"].Value != null)
                {
                    cbTransmission.SelectedIndex = cbTransmission.FindString(row.Cells["Transmission"].Value.ToString());
                }

                if (row.Cells["AirConditioning"].Value != null)
                {
                    bool airValue = (bool)row.Cells["AirConditioning"].Value;
                    string value = (airValue) ? "Var" : "Yoxdur";
                    cbAir.SelectedIndex = cbAir.FindString(value);
                }

                if (row.Cells["Mileage"].Value != null)
                {
                    decimal mileageValue;
                    if (decimal.TryParse(row.Cells["Mileage"].Value.ToString(), out mileageValue))
                    {
                        numMileage.Value = mileageValue;
                    }
                }

                if (row.Cells["Insurance"].Value != null)
                {
                    bool insuranceValue = (bool)row.Cells["Insurance"].Value;
                    string value = (insuranceValue) ? "Var" : "Yoxdur";
                    cbInsurance.SelectedIndex = cbInsurance.FindString(value);
                }

                if (row.Cells["CarStatus"].Value != null)
                {
                    bool status = (bool)row.Cells["CarStatus"].Value;
                    string value = (status) ? "İcarə edilib." : "Boşdur.";
                    cbStatus.SelectedIndex = cbStatus.FindString(value);
                }

                if (row.Cells["Price"].Value != null)
                {
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                }

                if (row.Cells["Image"].Value != null)
                {
                    pictureBox1.ImageLocation = row.Cells["Image"].Value.ToString();
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsCarValid())
            {
                Car car = new();
                car.CreatedAt = DateTime.Now;
                car.Name = txtName.Text;
                car.CategoryId = int.Parse(cbCategory.SelectedValue.ToString());
                car.Passanger = (short)numPassenger.Value;
                car.TransmissionId = int.Parse(cbTransmission.SelectedValue.ToString());
                car.AirConditioning = (cbAir.SelectedItem.ToString() == "Var");
                car.Mileage = (short)numMileage.Value;
                car.Insurance = (cbInsurance.SelectedItem.ToString() == "Var");
                car.Price = double.Parse(txtPrice.Text);
                car.CarStatus = (cbStatus.SelectedItem.ToString() == "İcarə edilib.");
                string fileName = Path.GetFileName(pictureBox1.ImageLocation);
                car.Image = Path.Combine(@"C:\Users\r\Downloads\", fileName);
                _carRepo.Add(car);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCarId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Car carToDelete = _carRepo.GetById(selectedCarId);
            if (carToDelete != null)
            {
                _carRepo.DeleteAsync(carToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Maşın mövcud deyil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedCarId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Car carToUpdate = _carRepo.GetById(selectedCarId);

            if (carToUpdate != null && IsCarValid())
            {
                carToUpdate.UpdatedAt = DateTime.Now;
                carToUpdate.Name = txtName.Text;
                carToUpdate.CategoryId = int.Parse(cbCategory.SelectedValue.ToString());
                carToUpdate.Passanger = (short)numPassenger.Value;
                carToUpdate.TransmissionId = int.Parse(cbTransmission.SelectedValue.ToString());
                carToUpdate.AirConditioning = (cbAir.SelectedItem.ToString() == "Var");
                carToUpdate.Mileage = (short)numMileage.Value;
                carToUpdate.Insurance = (cbInsurance.SelectedItem.ToString() == "Var");
                carToUpdate.Price = double.Parse(txtPrice.Text);
                carToUpdate.CarStatus = (cbStatus.SelectedItem.ToString() == "İcarə edilib.");
            }
            else if (carToUpdate == null)
            {
                MessageBox.Show("Maşın mövcud deyil.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            numPassenger.Value = 0;
            numMileage.Value = 0;
            cbAir.SelectedItem = null;
            cbCategory.SelectedItem = null;
            cbInsurance.SelectedItem = null;
            cbTransmission.SelectedItem = null;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            if (cbAir.Items.Count == 0)
            {
                cbAir.Items.Add("Var");
                cbAir.Items.Add("Yoxdur");
            }
            if (cbInsurance.Items.Count == 0)
            {
                cbInsurance.Items.Add("Var");
                cbInsurance.Items.Add("Yoxdur");
            }
            if (cbStatus.Items.Count == 0)
            {
                cbStatus.Items.Add("İcarə edilib.");
                cbStatus.Items.Add("Boşdur.");
            }
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = _categoryRepo.GetAll();

            cbTransmission.DisplayMember = "Type";
            cbTransmission.ValueMember = "Id";
            cbTransmission.DataSource = _transmissionRepository.GetAll();

            List<Car> cars = null;
            try
            {
                cars = _carRepo.GetAll();
            }
            catch
            {
                MessageBox.Show("Maşın mövcud deyil.");
            }

            if (cars != null)
            {
                var model = _mapper.Map<List<CarGetDTO>>(cars);
                dataGridView1.DataSource = model;
            }
        }

        private bool IsCarValid()
        {
            List<string> errorMessages = new List<string>();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorMessages.Add("Ad daxil edin.");
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorMessages.Add("Qiymət daxil edin.");
            }

            if (numPassenger.Value < 2)
            {
                errorMessages.Add("Minimum sərnişin sayı 2 olmalıdır.");
            }

            if (numMileage.Value <= 0)
            {
                errorMessages.Add("Sərfiyat dəyəri 0-dan böyük olmalıdır.");
            }

            if (cbAir.SelectedItem == null)
            {
                errorMessages.Add("Kondisoner olub-olmayacağını seçin.");
            }

            if (cbCategory.SelectedItem == null)
            {
                errorMessages.Add("Kateqoriya seçin.");
            }

            if (cbInsurance.SelectedItem == null)
            {
                errorMessages.Add("Sığorta olub-olmayacağını seçin.");
            }

            if (cbTransmission.SelectedItem == null)
            {
                errorMessages.Add("Motor növünü seçin.");
            }

            if (errorMessages.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error");
                return false;
            }

            return true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
