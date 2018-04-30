using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon
{
     class Conexion
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter da;
        public DataRow dr;
        public DataTable dt;
        public SqlDataReader sqldr;
        public SqlDataReader rider;
        public SqlDataReader drax;
        public void abrirConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=neon;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado " + ex.ToString());
            }
        }
        public void cerrarConexion(){
            cn.Close();
        }
        /*
        #region contrato viejo DON'T LOOK AT IT IT'S UGLY AS FUCK
        public void insertarContrato(string nombreCliente, string apellidoPaterno, string apellidoMaterno, string ciudad,
            string colonia, string numeroExterior, string numeroInterior, string nombreCumpleanero, string fecha, int tipoPaqute, int ninos) {
            try
            {               
                cmd = new SqlCommand("Insert into contrato(nombreCliente, apellidoPaterno, apellidoMaterno, ciudad, colonia, numeroExterior, numeroInterior, nombreCumpleanero, fecha, idPaquete, ninos) values" +
                "(@nombreCliente, @apellidoPaterno, @apellidoMaterno, @ciudad, @colonia, @numeroExterior, @numeroInterior, @nombreCumpleanero, @fecha, @tipoPaquete, @ninos)", cn);
                cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar);
                cmd.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar);
                cmd.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar);
                cmd.Parameters.Add("@ciudad", SqlDbType.VarChar);
                cmd.Parameters.Add("@colonia", SqlDbType.VarChar);
                cmd.Parameters.Add("@numeroExterior", SqlDbType.Int);
                cmd.Parameters.Add("@numeroInterior", SqlDbType.Int);
                cmd.Parameters.Add("@nombreCumpleanero", SqlDbType.VarChar);
                cmd.Parameters.Add("@fecha", SqlDbType.Date);
                cmd.Parameters.Add("@tipoPaquete", SqlDbType.Int);
                cmd.Parameters.Add("@ninos", SqlDbType.Int);
                cmd.Parameters["@nombreCliente"].Value = nombreCliente;
                cmd.Parameters["@apellidoPaterno"].Value = apellidoPaterno;
                cmd.Parameters["@apellidoMaterno"].Value = apellidoMaterno;
                cmd.Parameters["@ciudad"].Value = ciudad;
                cmd.Parameters["@colonia"].Value = colonia;
                cmd.Parameters["@numeroExterior"].Value = numeroExterior;
                cmd.Parameters["@numeroInterior"].Value = numeroInterior;
                cmd.Parameters["@nombreCumpleanero"].Value = nombreCumpleanero;
                cmd.Parameters["@fecha"].Value = fecha;
                cmd.Parameters["@tipoPaquete"].Value = tipoPaqute;
                cmd.Parameters["@ninos"].Value = ninos;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contrato insertado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Looks like something went wrong " + ex.Message);
            }


        }
        #endregion
        */
        public void insertarCliente(string nombreCliente, string apellidoPaterno, string apellidoMaterno, string direccion, string telefono, string email) {
            try
            {
            cmd = new SqlCommand("insert into clientes (nombreCliente, apellidoPaterno, apellidoMaterno, direccion, telefono, email) values" +
                "(@nombreCliente, @apellidoPaterno, @apellidoMaterno, @direccion, @telefono, @email)",cn);
            cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar);
            cmd.Parameters.Add("@apellidoPaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@apellidoMaterno", SqlDbType.VarChar);
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@nombreCliente"].Value = nombreCliente;
            cmd.Parameters["@apellidoPaterno"].Value = apellidoPaterno;
            cmd.Parameters["@apellidoMaterno"].Value = apellidoMaterno;
            cmd.Parameters["@direccion"].Value = direccion;
            cmd.Parameters["@telefono"].Value = telefono;
            cmd.Parameters["@email"].Value = email;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente insertado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong during the client registration  " + ex.Message);
            }

        }
        public void insertarContrato(string fecha_evento, int ID_paquete, string forma_pago, double total_pagar, string nombreCumpleanero, int anosCumpleanero) {           
            try
            {
                int no_cliente = 0;
                cmd = new SqlCommand("select IDENT_CURRENT('clientes')", cn);
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    no_cliente = Convert.ToInt32(sqldr.GetValue(0));
                }
                sqldr.Close();
                cmd = new SqlCommand("insert into contrato (no_cliente, fecha_evento, ID_paquete, forma_pago, total_pagar, nombreCumpleanero, anosCumpleanero) values" +
                    "(@no_cliente, @fecha_evento, @ID_paquete, @forma_pago, @total_pagar, @nombreCumpleanero, @anosCumpleanero)", cn);
                cmd.Parameters.Add("@no_cliente", SqlDbType.Int);
                cmd.Parameters.Add("@fecha_evento", SqlDbType.Date);
                cmd.Parameters.Add("@ID_paquete", SqlDbType.Int);
                cmd.Parameters.Add("@forma_pago", SqlDbType.VarChar);
                cmd.Parameters.Add("@total_pagar", SqlDbType.Money);
                cmd.Parameters.Add("@nombreCumpleanero", SqlDbType.VarChar);
                cmd.Parameters.Add("@anosCumpleanero", SqlDbType.Int);
                cmd.Parameters["@no_cliente"].Value = no_cliente;
                cmd.Parameters["@fecha_evento"].Value = fecha_evento;
                cmd.Parameters["@ID_paquete"].Value = ID_paquete;
                cmd.Parameters["@forma_pago"].Value = forma_pago;
                cmd.Parameters["@total_pagar"].Value = total_pagar;
                cmd.Parameters["@nombreCumpleanero"].Value = nombreCumpleanero;
                cmd.Parameters["@anosCumpleanero"].Value = Convert.ToInt32(anosCumpleanero);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contrato insertado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal durante el proceso de inserción de contrato " + ex.Message);
            }
        }

        public void insertarExtraContrato(ListBox.SelectedIndexCollection list) {
            int idContrato = 0;
            cmd = new SqlCommand("select IDENT_CURRENT('contrato')", cn);
            sqldr = cmd.ExecuteReader();
            while (sqldr.Read())
            {
                idContrato = Convert.ToInt32(sqldr.GetValue(0));
            }
            sqldr.Close();
            cmd = new SqlCommand("insert into relacionExtrasContrato(idContrato, idExtra) values (@idContrato, @extra)", cn);
            cmd.Parameters.Add("@idContrato", SqlDbType.Int);
            cmd.Parameters.Add("@extra", SqlDbType.Int);
            cmd.Parameters["@idContrato"].Value = idContrato;
            foreach (var item in list)
            {
                try
                {
                    cmd.Parameters["@extra"].Value = item;
                    cmd.ExecuteNonQuery();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable LlenarTabla(string cadena)
        {
            DataTable datTable = new DataTable();
       
            cmd = new SqlCommand(cadena, cn);
            rider = cmd.ExecuteReader();
            if (rider.HasRows)
            {
                rider.Close();
                da = new SqlDataAdapter(cadena, cn);
                da.Fill(datTable);
            }
           
            return datTable;
        }

        public void llenarcmb(ComboBox cb)
        {
            cmd = new SqlCommand("Select extra from extras",cn);
            sqldr = cmd.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr["extra"].ToString());
            }
            sqldr.Close();
        }

        public List<Extra> llenarListBox(ListBox list) {
            cmd = new SqlCommand ("select extra, precio from extras order by idExtra asc", cn);
            sqldr = cmd.ExecuteReader();
            list.DisplayMember = "extra";
            List < Extra > listaExtras= new List<Extra>();            
            while (sqldr.Read())
            {
                list.Items.Add(sqldr["extra"]);
                Extra extra = new Extra();
                extra.nombreExtra = sqldr["extra"].ToString();
                extra.precio = Convert.ToInt32(sqldr["precio"]);
                listaExtras.Add(extra);
            }
            sqldr.Close();
            return listaExtras;
        }


        public string[] ObtenerDatosConstancia(string cadena)
        {
            string[] Arreglo;
            Arreglo = null;
            cn.Open();
            cmd = new SqlCommand(cadena, cn);
            drax = cmd.ExecuteReader();

            if (drax.HasRows)
            {
                Arreglo = new string[4];
                drax.Read();
                Arreglo[0] = drax["nombreCliente"].ToString();
                Arreglo[1] = drax["apellidoPaterno"].ToString();
                Arreglo[2] = drax["apellidoMaterno"].ToString();
                Arreglo[3] = drax["fecha"].ToString();
            }
            drax.Close();
            cn.Close();
            return Arreglo;
        }

        
    }
}
