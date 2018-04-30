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
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
            
    }
        Paquetes pa = new Paquetes();
        ConsultaContratos cc = new ConsultaContratos();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //252, 491, 180,0, 129,0
            if (LeftPanel.Height == 491 && LeftPanel.Width == 180)
            {
                LeftPanel.Width = 50;
                LeftPanel.Height = 491;
                RightPanel.Location = new Point(129, 0);
                
            }
            else
            {
                LeftPanel.Width = 180;
                LeftPanel.Height = 491;
                RightPanel.Location = new Point(180, 0);
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pa.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cc.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Eventos ev = new Eventos();
            ev.ShowDialog();
        }
    }
}
