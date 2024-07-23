using AutoMapper;
using Data.DTOs.TransmissionDTO;
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
    public partial class Uc_Transmission : UserControl
    {
        readonly ITransmissionRepository _transmissionRepo;
        readonly IMapper _mapper;
        public Uc_Transmission(ITransmissionRepository transmissionRepository, IMapper mapper)
        {
            _transmissionRepo = transmissionRepository;
            _mapper = mapper;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsTransmissionTypeValid())
            {
                Transmission transmission = new();
                transmission.CreatedAt = DateTime.Now;
                transmission.Type = txtType.Text;
                _transmissionRepo.Add(transmission);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedTransmissionId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Transmission transmissionToDelete = _transmissionRepo.GetById(selectedTransmissionId);
            if (transmissionToDelete != null)
            {
                _transmissionRepo.DeleteAsync(transmissionToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Baqaj mövcud deyil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedTransmissionId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Transmission transmissionToUpdate = _transmissionRepo.GetById(selectedTransmissionId);

            if (transmissionToUpdate != null && IsTransmissionTypeValid())
            {
                transmissionToUpdate.Type = txtType.Text;
                transmissionToUpdate.UpdatedAt = DateTime.Now;
                _transmissionRepo.UpdateAsync(transmissionToUpdate);
                LoadData();
            }
            else if (transmissionToUpdate == null)
            {
                MessageBox.Show("Baqaj mövcud deyil.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Type"].Value != null)
                {
                    txtType.Text = row.Cells["Type"].Value.ToString();
                }
            }
        }

        private void Uc_Transmission_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            List<Transmission> transmissions = null;
            try
            {
                transmissions = _transmissionRepo.GetAll();
            }
            catch
            {
                MessageBox.Show("Motor mövcud deyil.");
            }

            if (transmissions != null)
            {
                var model = _mapper.Map<List<TransmissionGetDTO>>(transmissions);
                dataGridView1.DataSource = model;
            }
        }
        private bool IsTransmissionTypeValid()
        {
            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Baqaj növü daxil edin.");
                return false;
            }
            return true;
        }
    }
}
