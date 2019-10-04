namespace NetFlics
{
    partial class FormNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.gbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.lbErrorFormaPago = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbErrorSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErrorCargo = new System.Windows.Forms.Label();
            this.lbErrorUsuario = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.gbDatosUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario (eje: j.perez)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Nuevo Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNombreUsuario.Location = new System.Drawing.Point(10, 43);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(295, 23);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreUsuario_KeyDown);
            // 
            // gbDatosUsuarios
            // 
            this.gbDatosUsuarios.BackColor = System.Drawing.Color.DarkGray;
            this.gbDatosUsuarios.Controls.Add(this.lbErrorFormaPago);
            this.gbDatosUsuarios.Controls.Add(this.cbFormaPago);
            this.gbDatosUsuarios.Controls.Add(this.label7);
            this.gbDatosUsuarios.Controls.Add(this.lbErrorSalario);
            this.gbDatosUsuarios.Controls.Add(this.txtSalario);
            this.gbDatosUsuarios.Controls.Add(this.label5);
            this.gbDatosUsuarios.Controls.Add(this.lbErrorCargo);
            this.gbDatosUsuarios.Controls.Add(this.lbErrorUsuario);
            this.gbDatosUsuarios.Controls.Add(this.cbCargo);
            this.gbDatosUsuarios.Controls.Add(this.label4);
            this.gbDatosUsuarios.Controls.Add(this.txtNombreUsuario);
            this.gbDatosUsuarios.Controls.Add(this.label1);
            this.gbDatosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.gbDatosUsuarios.Location = new System.Drawing.Point(12, 56);
            this.gbDatosUsuarios.Name = "gbDatosUsuarios";
            this.gbDatosUsuarios.Size = new System.Drawing.Size(860, 133);
            this.gbDatosUsuarios.TabIndex = 3;
            this.gbDatosUsuarios.TabStop = false;
            this.gbDatosUsuarios.Text = "Datos de Usuario";
            // 
            // lbErrorFormaPago
            // 
            this.lbErrorFormaPago.AutoSize = true;
            this.lbErrorFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorFormaPago.ForeColor = System.Drawing.Color.Red;
            this.lbErrorFormaPago.Location = new System.Drawing.Point(585, 69);
            this.lbErrorFormaPago.Name = "lbErrorFormaPago";
            this.lbErrorFormaPago.Size = new System.Drawing.Size(159, 13);
            this.lbErrorFormaPago.TabIndex = 12;
            this.lbErrorFormaPago.Text = "Favor elegir forma de pago";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.BackColor = System.Drawing.Color.Silver;
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFormaPago.ForeColor = System.Drawing.Color.DarkRed;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "Mensual",
            "Quinsenal",
            "Semanal"});
            this.cbFormaPago.Location = new System.Drawing.Point(583, 42);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(161, 24);
            this.cbFormaPago.TabIndex = 10;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(579, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Forma e Pago";
            // 
            // lbErrorSalario
            // 
            this.lbErrorSalario.AutoSize = true;
            this.lbErrorSalario.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorSalario.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSalario.Location = new System.Drawing.Point(443, 69);
            this.lbErrorSalario.Name = "lbErrorSalario";
            this.lbErrorSalario.Size = new System.Drawing.Size(137, 13);
            this.lbErrorSalario.TabIndex = 9;
            this.lbErrorSalario.Text = "Favor introducir salario";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.Silver;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSalario.Location = new System.Drawing.Point(446, 43);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(131, 23);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(442, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salario (RD$)";
            // 
            // lbErrorCargo
            // 
            this.lbErrorCargo.AutoSize = true;
            this.lbErrorCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorCargo.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCargo.Location = new System.Drawing.Point(317, 69);
            this.lbErrorCargo.Name = "lbErrorCargo";
            this.lbErrorCargo.Size = new System.Drawing.Size(110, 13);
            this.lbErrorCargo.TabIndex = 6;
            this.lbErrorCargo.Text = "Favor elegir cargo";
            // 
            // lbErrorUsuario
            // 
            this.lbErrorUsuario.AutoSize = true;
            this.lbErrorUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUsuario.Location = new System.Drawing.Point(6, 69);
            this.lbErrorUsuario.Name = "lbErrorUsuario";
            this.lbErrorUsuario.Size = new System.Drawing.Size(240, 13);
            this.lbErrorUsuario.TabIndex = 5;
            this.lbErrorUsuario.Text = "Este nombre de usario no esta disponible";
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.Silver;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCargo.ForeColor = System.Drawing.Color.DarkRed;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Contable",
            "Supervisor",
            "Tendero"});
            this.cbCargo.Location = new System.Drawing.Point(315, 42);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 24);
            this.cbCargo.TabIndex = 1;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            this.cbCargo.Click += new System.EventHandler(this.cbCargo_Click);
            this.cbCargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCargo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(311, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.BackColor = System.Drawing.Color.DarkGray;
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.ForeColor = System.Drawing.Color.DarkRed;
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 221);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(860, 369);
            this.gbDatosPersonales.TabIndex = 4;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 53);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(58, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "etFlics";
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.Silver;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.ForeColor = System.Drawing.Color.DarkRed;
            this.bttAgregar.Location = new System.Drawing.Point(528, 616);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(169, 33);
            this.bttAgregar.TabIndex = 0;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.ForeColor = System.Drawing.Color.Silver;
            this.bttCancelar.Location = new System.Drawing.Point(703, 614);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(169, 33);
            this.bttCancelar.TabIndex = 15;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDatosUsuarios);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nuevo Usuario";
            this.Load += new System.EventHandler(this.FormNewUser_Load);
            this.gbDatosUsuarios.ResumeLayout(false);
            this.gbDatosUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.GroupBox gbDatosUsuarios;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbErrorUsuario;
        private System.Windows.Forms.Label lbErrorCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErrorSalario;
        private System.Windows.Forms.Label lbErrorFormaPago;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label label7;
    }
}