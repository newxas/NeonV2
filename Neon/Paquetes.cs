using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon
{
    public partial class Paquetes : Form
    {
        public Paquetes()
        {
            InitializeComponent();
            pictureBox1.Image = null;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                pictureBox1.Image = Neon.Properties.Resources.Basico; 
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Neon.Properties.Resources.Completos1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                PaqueteBasico paba = new PaqueteBasico();
                paba.ShowDialog();
            }
            if (comboBox1.SelectedIndex==1)
            {
                PaqueteCompleto paco = new PaqueteCompleto();
                paco.ShowDialog();
            }
        }
    }
}
