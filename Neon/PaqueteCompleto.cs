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
    public partial class PaqueteCompleto : Form
    {
        float sum = 0;
        float total = 0;
        Conexion con = new Conexion();
        List<Extra> listExtra = new List<Extra>();
        Calculo cal = new Calculo();
        public PaqueteCompleto()
        {
            InitializeComponent();
            con.abrirConexion();
            listExtra = con.llenarListBox(lstExtra);
            cmbNum.SelectedIndex = 0;
        }

        private void PaqueteCompleto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*txtTotal.Text = (string.IsNullOrEmpty(txtTotal.Text)) ? Convert.ToString(total) : total.ToString();*/
            if (cmbNum.SelectedIndex==0)
            {
                sum = 6000;
                txtTotal.Text = (sum+total).ToString();
            }
            else
            {
                sum = 7500;
                txtTotal.Text = (sum+total).ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(cmbNum.SelectedItem);
            con.insertarCliente(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
            con.insertarContrato(monthCalendar1.SelectionRange.Start.ToShortDateString(), 1, txtFormaPago.Text, Convert.ToDouble(txtTotal.Text), txtCumpleañero.Text, Convert.ToInt32(txtAnosCumpleanero.Text));
            if (cmbExtras.SelectedIndex == 0)
            {
                con.insertarExtraContrato(lstExtra.SelectedIndices);
            }
        }

        private void PaqueteCompleto_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.cerrarConexion();
        }

        private void cmbExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExtras.SelectedIndex == 0)
            {
                lstExtra.Enabled = true;
            }
            else
            {
                lstExtra.Enabled = false;
            }
        }

        private void lstExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = cal.calculoTotal(lstExtra.SelectedItems, listExtra);
            txtTotal.Text = (sum + total).ToString();
        }
    }
}
