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
    public partial class Uc_CarsGet : UserControl
    {
        public Uc_CarsGet()
        {
            InitializeComponent();
        }
        public FlowLayoutPanel CarsFlowLayoutPanel
        {
            get { return flowLayoutPanel1; }
        }
    }
}
