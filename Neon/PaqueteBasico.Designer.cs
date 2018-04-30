namespace Neon
{
    partial class PaqueteBasico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbExtras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstExtra = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCumple = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCumpleañero = new System.Windows.Forms.TextBox();
            this.txtAnosCumpleanero = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 52);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(72, 22);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(9, 99);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(134, 22);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Apellido paterno:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(9, 190);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(84, 22);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Dirección:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(38, 370);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 22);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(653, 348);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(527, 388);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(186, 30);
            this.txtTotal.TabIndex = 25;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(203, 370);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // cmbExtras
            // 
            this.cmbExtras.FormattingEnabled = true;
            this.cmbExtras.Items.AddRange(new object[] {
            "Si ",
            "No"});
            this.cmbExtras.Location = new System.Drawing.Point(817, 102);
            this.cmbExtras.Name = "cmbExtras";
            this.cmbExtras.Size = new System.Drawing.Size(121, 21);
            this.cmbExtras.TabIndex = 8;
            this.cmbExtras.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Extras:";
            // 
            // lstExtra
            // 
            this.lstExtra.Enabled = false;
            this.lstExtra.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExtra.FormattingEnabled = true;
            this.lstExtra.ItemHeight = 22;
            this.lstExtra.Location = new System.Drawing.Point(753, 141);
            this.lstExtra.Name = "lstExtra";
            this.lstExtra.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstExtra.Size = new System.Drawing.Size(185, 312);
            this.lstExtra.TabIndex = 9;
            this.lstExtra.SelectedIndexChanged += new System.EventHandler(this.lstExtra_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCumple
            // 
            this.lblCumple.AutoSize = true;
            this.lblCumple.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumple.Location = new System.Drawing.Point(12, 260);
            this.lblCumple.Name = "lblCumple";
            this.lblCumple.Size = new System.Drawing.Size(170, 22);
            this.lblCumple.TabIndex = 12;
            this.lblCumple.Text = "Nombre Cumpleañero:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(185, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(185, 99);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(266, 26);
            this.txtApellidoPaterno.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(185, 190);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(266, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCumpleañero
            // 
            this.txtCumpleañero.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCumpleañero.Location = new System.Drawing.Point(188, 257);
            this.txtCumpleañero.Name = "txtCumpleañero";
            this.txtCumpleañero.Size = new System.Drawing.Size(266, 26);
            this.txtCumpleañero.TabIndex = 6;
            // 
            // txtAnosCumpleanero
            // 
            this.txtAnosCumpleanero.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnosCumpleanero.Location = new System.Drawing.Point(261, 304);
            this.txtAnosCumpleanero.Name = "txtAnosCumpleanero";
            this.txtAnosCumpleanero.Size = new System.Drawing.Size(193, 26);
            this.txtAnosCumpleanero.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(852, 502);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 30);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(9, 145);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(138, 22);
            this.lblApellidoMaterno.TabIndex = 20;
            this.lblApellidoMaterno.Text = "Apellido materno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(185, 141);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(266, 26);
            this.txtApellidoMaterno.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(565, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Generar Contrato";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Años del cumpleñero a celebrar:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(487, 52);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(122, 22);
            this.lblFormaPago.TabIndex = 36;
            this.lblFormaPago.Text = "Forma de pago:";
            this.lblFormaPago.Click += new System.EventHandler(this.lblFormaPago_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPago.Location = new System.Drawing.Point(626, 44);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(186, 30);
            this.txtFormaPago.TabIndex = 10;
            this.txtFormaPago.TextChanged += new System.EventHandler(this.txtFormaPago_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Telefono:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(540, 194);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(193, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(540, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // PaqueteBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 586);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAnosCumpleanero);
            this.Controls.Add(this.txtCumpleañero);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCumple);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstExtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbExtras);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.lblNombreCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaqueteBasico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaqueteBasico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaqueteBasico_FormClosed);
            this.Load += new System.EventHandler(this.PaqueteBasico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmbExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstExtra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCumple;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCumpleañero;
        private System.Windows.Forms.TextBox txtAnosCumpleanero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
    }
}