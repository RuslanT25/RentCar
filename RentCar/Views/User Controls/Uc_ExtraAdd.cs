using AutoMapper;
using Data.DTOs.ExtraDTO;
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
    public partial class Uc_ExtraAdd : UserControl
    {
        readonly IExtraRepository _extraRepo;
        readonly IMapper _mapper;
        public Uc_ExtraAdd(IExtraRepository extraRepository, IMapper mapper)
        {
            _extraRepo = extraRepository;
            _mapper = mapper;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExtra.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Name"].Value != null)
                {
                    txtExtra.Text = row.Cells["Name"].Value.ToString();
                }
            }
        }

        private void Uc_Extra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsExtraValid())
            {
                Extra extra = new();
                extra.CreatedAt = DateTime.Now;
                extra.Name = txtExtra.Text;
                _extraRepo.Add(extra);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedExtraId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Extra extraToDelete = _extraRepo.GetById(selectedExtraId);
            if (extraToDelete != null)
            {
                _extraRepo.DeleteAsync(extraToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Ekstra mövcud deyil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedExtraId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Extra extraToUpdate = _extraRepo.GetById(selectedExtraId);

            if (extraToUpdate != null && IsExtraValid())
            {
                extraToUpdate.Name = txtExtra.Text;
                extraToUpdate.UpdatedAt = DateTime.Now;
                _extraRepo.UpdateAsync(extraToUpdate);
                LoadData();
            }
            else if (extraToUpdate == null)
            {
                MessageBox.Show("Ekstra mövcud deyil.");
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            List<Extra> extras = null;
            try
            {
                extras = _extraRepo.GetAll();
            }
            catch
            {
                MessageBox.Show("Ekstra mövcud deyil.");
            }

            if (extras != null)
            {
                var model = _mapper.Map<List<ExtraGetDTO>>(extras);
                dataGridView1.DataSource = model;
            }
        }
        private bool IsExtraValid()
        {
            if (string.IsNullOrWhiteSpace(txtExtra.Text))
            {
                MessageBox.Show("Ekstra daxil edin.");
                return false;
            }
            return true;
        }
    }
}
