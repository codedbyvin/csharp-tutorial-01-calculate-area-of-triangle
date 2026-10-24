using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Base = nudBase.Value;
            decimal Height = nudHeight.Value;
            decimal Area = 0;
            
            Area = 0.5m * Base * Height;
            
            nudArea.Value = Area;
        }
    }
}
