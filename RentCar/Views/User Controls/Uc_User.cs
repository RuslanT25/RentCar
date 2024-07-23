using AutoMapper;
using Data.DTOs.UserDTO;
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
    public partial class Uc_User : UserControl
    {
        readonly IUserRepository _userRepo;
        readonly IMapper _mapper;
        public Uc_User(IUserRepository userRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _mapper = mapper;
            InitializeComponent();
        }

        private void Uc_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Email"].Value != null)
                {
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                }

                if (row.Cells["Password"].Value != null)
                {
                    txtPassword.Text = row.Cells["Password"].Value.ToString();
                }

                if (row.Cells["Role"].Value != null)
                {
                    cbRole.SelectedIndex = cbRole.FindString(row.Cells["Role"].Value.ToString());
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsUserValid())
            {
                User user = new()
                {
                    CreatedAt = DateTime.Now,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Role = cbRole.SelectedItem.ToString()
                };
                _userRepo.Add(user);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            User userToDelete = _userRepo.GetById(selectedUserId);
            if (userToDelete != null)
            {
                _userRepo.DeleteAsync(userToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Admin ve ya işçi mövcud deyil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            User userToUpdate = _userRepo.GetById(selectedUserId);

            if (userToUpdate != null && IsUserValid())
            {
                userToUpdate.Email = txtEmail.Text;
                userToUpdate.Password = txtPassword.Text;
                userToUpdate.Role = cbRole.SelectedItem.ToString();
                userToUpdate.UpdatedAt = DateTime.Now;
                _userRepo.UpdateAsync(userToUpdate);
                LoadData();
            }
            else if (userToUpdate == null)
            {
                MessageBox.Show("Admin ve ya işçi mövcud deyil.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            List<User> users = null;
            try
            {
                users = _userRepo.GetAll();
            }
            catch
            {
                MessageBox.Show("Admin ve ya işçi mövcud deyil.");
            }

            if (users != null)
            {
                var model = _mapper.Map<List<UserGetDTO>>(users);
                dataGridView1.DataSource = model;
            }
        }
        private bool IsUserValid()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email daxil edin.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parol daxil edin.");
                return false;
            }
            else if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Vəzifə seçin.");
                return false;
            }

            return true;
        }
    }
}
