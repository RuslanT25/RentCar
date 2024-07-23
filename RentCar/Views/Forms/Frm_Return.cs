using AutoMapper;
using Data.DTOs.CustomerDTO;
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

namespace RentCar.Views.Forms
{
    public partial class Frm_Return : Form
    {
        readonly ICustomerRepository _customerRepo;
        readonly IMapper _mapper;
        Customer selectedCustomer;
        public Frm_Return(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepo = customerRepository;
            _mapper = mapper;
            InitializeComponent();

        }

        private void Frm_Return_Load(object sender, EventArgs e)
        {
            var customers = _customerRepo.GetCustomers().Where(c => c.Car.CarStatus);

            var model = _mapper.Map<List<CustomerGetDTO>>(customers);
            dataGridView1.DataSource = model;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                selectedCustomer.Car.CarStatus = false;

                _customerRepo.UpdateAsync(selectedCustomer);
                var customers = _customerRepo.GetCustomers().Where(c => c.Car.CarStatus);

                var model = _mapper.Map<List<CustomerGetDTO>>(customers);
                dataGridView1.DataSource = model;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CustomerGetDTO selectedCustomerDTO = (CustomerGetDTO)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                selectedCustomer = _customerRepo.GetCustomers().FirstOrDefault(c => c.Id == selectedCustomerDTO.Id);
            }
        }
    }
}
