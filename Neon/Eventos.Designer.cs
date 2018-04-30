namespace Neon
{
    partial class Eventos
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
            this.dtgEventos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtCumpleañero = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblCumplenero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEventos
            // 
            this.dtgEventos.AllowUserToAddRows = false;
            this.dtgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEventos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventos.Location = new System.Drawing.Point(569, 0);
            this.dtgEventos.Name = "dtgEventos";
            this.dtgEventos.Size = new System.Drawing.Size(347, 442);
            this.dtgEventos.TabIndex = 0;
            this.dtgEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEventos_CellClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(202, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 33);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(202, 221);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(338, 33);
            this.txtApellidoM.TabIndex = 2;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(202, 152);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(338, 33);
            this.txtApellidoP.TabIndex = 1;
            // 
            // txtCumpleañero
            // 
            this.txtCumpleañero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCumpleañero.Location = new System.Drawing.Point(202, 294);
            this.txtCumpleañero.Name = "txtCumpleañero";
            this.txtCumpleañero.Size = new System.Drawing.Size(338, 33);
            this.txtCumpleañero.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(202, 376);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(338, 33);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(177, 25);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre Cliente";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoP.Location = new System.Drawing.Point(6, 155);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(184, 25);
            this.lblApellidoP.TabIndex = 8;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.Location = new System.Drawing.Point(6, 224);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(190, 25);
            this.lblApellidoM.TabIndex = 9;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // lblCumplenero
            // 
            this.lblCumplenero.AutoSize = true;
            this.lblCumplenero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumplenero.Location = new System.Drawing.Point(12, 302);
            this.lblCumplenero.Name = "lblCumplenero";
            this.lblCumplenero.Size = new System.Drawing.Size(153, 25);
            this.lblCumplenero.TabIndex = 10;
            this.lblCumplenero.Text = "Cumpleañero";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(44, 384);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 25);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 445);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCumplenero);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCumpleañero);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtgEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEventos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtCumpleañero;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblCumplenero;
        private System.Windows.Forms.Label lblFecha;
    }
}