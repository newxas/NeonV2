using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Text;
using System.Data;
using System.Data.SqlClient;
namespace Neon
{
    public partial class PaqueteBasico : Form
    {
        Conexion con = new Conexion();
        float total=4000;
        String direccion;
        String NC;
        string[,] DatosCliente;
        List<Extra> listExtra = new List<Extra>();
        Calculo cal = new Calculo();

        public PaqueteBasico()
        {
            InitializeComponent();
            txtTotal.Text = total.ToString();
            con.abrirConexion();
            listExtra = con.llenarListBox(lstExtra);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void PaqueteBasico_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// aca //////////////           
            con.insertarCliente(txtNombre.Text,txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
            con.insertarContrato(monthCalendar1.SelectionRange.Start.ToShortDateString(), 1, txtFormaPago.Text, Convert.ToDouble(txtTotal.Text), txtCumpleañero.Text, Convert.ToInt32(txtAnosCumpleanero.Text));
            if (cmbExtras.SelectedIndex == 0)
            {
                con.insertarExtraContrato(lstExtra.SelectedIndices);
            }
        }

        private void PaqueteBasico_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.cerrarConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearPdf();
            MessageBox.Show("Archivo Creado", "Exito");
        }

        private void lstExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (total + cal.calculoTotal(lstExtra.SelectedItems, listExtra)).ToString();
        }

        #region Metodos
        private void CrearPdf()
        {
            NC=txtNombre.Text;
            DialogResult res = this.folderBrowserDialog1.ShowDialog();
            if (res==DialogResult.OK)
            {
                direccion = folderBrowserDialog1.SelectedPath;
                Document doc = new Document(iTextSharp.text.PageSize.LETTER);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(direccion+"\\"+NC+".pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Image Superior = iTextSharp.text.Image.GetInstance(Directory.GetCurrentDirectory() + "\\Superior.png");
                doc.Add(Superior);

                doc.Add(new Paragraph("\n\n"));
                Paragraph paragraph = new Paragraph("La persona: " + txtNombre.Text + " " + txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text + " " + " realizara un evento en la fecha: " + monthCalendar1.SelectionRange.Start.ToShortDateString());
                doc.Add(paragraph);

                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Con esto se compromete a hacer un buen uso del local, responsabilizandose en caso de algun accidente, daños a aparatos o daños al inmueble"));
                doc.Add(new Paragraph("\n\n"));
                doc.Add(new Paragraph("_____________________________"));
                doc.Add(new Paragraph("\t Firma de enterado"));
                doc.Close();
            }
           
        }
        #endregion

        private void lblFormaPago_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFormaPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
