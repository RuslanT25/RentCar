using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Customize
{
    public class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripBorder
        {
            get { return Color.Transparent; }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.Transparent; }
        }

        public override Color MenuBorder
        {
            get { return Color.Transparent; }
        }
    }
}
