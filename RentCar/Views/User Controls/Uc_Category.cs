using AutoMapper;
using Data.DTOs.CategoryDTO;
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
    public partial class Uc_Category : UserControl
    {
        readonly ICategoryRepository _categoryRepo;
        readonly IMapper _mapper;
        public Uc_Category(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepo = categoryRepository;
            _mapper = mapper;
            InitializeComponent();
        }
        private void Uc_Category_Load(object sender, EventArgs e)
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
                    txtCategory.Text = row.Cells["Name"].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsCategoryValid())
            {
                Category category = new();
                category.CreatedAt = DateTime.Now;
                category.Name = txtCategory.Text;
                _categoryRepo.Add(category);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Category categoryToDelete = _categoryRepo.GetById(selectedCategoryId);
            if (categoryToDelete != null)
            {
                _categoryRepo.DeleteAsync(categoryToDelete);
                LoadData();
            }
            else
            {
                MessageBox.Show("Kateqoriya mövcud deyil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            Category categoryToUpdate = _categoryRepo.GetById(selectedCategoryId);

            if (categoryToUpdate != null && IsCategoryValid())
            {
                categoryToUpdate.Name = txtCategory.Text;
                categoryToUpdate.UpdatedAt = DateTime.Now;
                _categoryRepo.UpdateAsync(categoryToUpdate);
                LoadData();
            }
            else if (categoryToUpdate == null)
            {
                MessageBox.Show("Kateqoriya mövcud deyil.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            List<Category> categories = null;
            try
            {
                categories = _categoryRepo.GetAll();
            }
            catch
            {
                MessageBox.Show("Kateqoriya mövcud deyil.");
            }

            if (categories != null)
            {
                var model = _mapper.Map<List<CategoryGetDTO>>(categories);
                dataGridView1.DataSource = model;
            }
        }
        private bool IsCategoryValid()
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Kateqoriya daxil edin.");
                return false;
            }
            return true;
        }
    }
}
