using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Neon
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
            string query = "select nombreCliente,apellidoPaterno,apellidoMaterno,nombreCumpleanero,fecha from contrato where fecha >= GETDATE();";
            Conexion c = new Conexion();
            c.abrirConexion();
            dtgEventos.DataSource = c.LlenarTabla(query);
            c.cerrarConexion();
            bloqueoxbloqueo();
            dtgEventos.RowHeadersDefaultCellStyle.Font = new Font("Verdana", 16);
            dtgEventos.Columns["nombreCliente"].Visible = false;
            dtgEventos.Columns["apellidoPaterno"].Visible = false;
            dtgEventos.Columns["apellidoMaterno"].Visible = false;
            dtgEventos.Columns["nombreCumpleanero"].Visible = false;

        }

        private void dtgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEventos.DataSource!=null)
            {
                txtNombre.Text = dtgEventos.Rows[dtgEventos.CurrentRow.Index].Cells[0].Value.ToString();
                txtApellidoM.Text = dtgEventos.Rows[dtgEventos.CurrentRow.Index].Cells[1].Value.ToString();
                txtApellidoP.Text = dtgEventos.Rows[dtgEventos.CurrentRow.Index].Cells[2].Value.ToString();
                txtCumpleañero.Text = dtgEventos.Rows[dtgEventos.CurrentRow.Index].Cells[3].Value.ToString();
                txtFecha.Text= dtgEventos.Rows[dtgEventos.CurrentRow.Index].Cells[4].Value.ToString();
            }
        }

        private void bloqueoxbloqueo()
        {
            txtNombre.Enabled = false;
            txtApellidoM.Enabled = false;
            txtApellidoP.Enabled = false;
            txtCumpleañero.Enabled = false;
            txtFecha.Enabled = false;
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
