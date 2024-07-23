using Data.Entities;
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
    public partial class Uc_ExtraGet : UserControl
    {
        public string Text
        {
            get { return chbExtra.Text; }
            set { chbExtra.Text = value; }
        }
        public Uc_ExtraGet(Extra extra)
        {
            InitializeComponent();
            DisplayExtra(extra);
        }

        public void DisplayExtra(Extra extra)
        {
            Text = extra.Name;
        }
        public event EventHandler CheckBoxCheckedChanged;

        private void ChbExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExtra.Checked)
            {
                CheckBoxCheckedChanged?.Invoke(this, e);
            }
        }
    }
}
