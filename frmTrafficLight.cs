using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class frmTrafficLight : Form
    {
        public frmTrafficLight()
        {
            InitializeComponent();
        }

        private void frmTrafficLight_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
            ctrlTrafficLight2.Start();
        }

        private void ctrlTrafficLight1_RedOn(object sender, ctrlTrafficLight.OnTrafficColorChangeEventArgs e)
        {
            MessageBox.Show($"{e.CurrentColor}");
        }
    }
}
