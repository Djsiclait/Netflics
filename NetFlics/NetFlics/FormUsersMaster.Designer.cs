namespace NetFlics
{
    partial class FormUsersMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsersMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.bttVolver = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.txtBuscarText = new System.Windows.Forms.TextBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttCambiar = new System.Windows.Forms.Button();
            this.bttModificarUsuario = new System.Windows.Forms.Button();
            this.bttNuevoUsuario = new System.Windows.Forms.Button();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios Registrados";
            // 
            // bttVolver
            // 
            this.bttVolver.BackColor = System.Drawing.Color.DarkGray;
            this.bttVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVolver.ForeColor = System.Drawing.Color.Red;
            this.bttVolver.Location = new System.Drawing.Point(13, 9);
            this.bttVolver.Name = "bttVolver";
            this.bttVolver.Size = new System.Drawing.Size(75, 23);
            this.bttVolver.TabIndex = 1;
            this.bttVolver.Text = "Volver";
            this.bttVolver.UseVisualStyleBackColor = false;
            this.bttVolver.Click += new System.EventHandler(this.bttVolver_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.Gray;
            this.gbBuscar.Controls.Add(this.bttBuscar);
            this.gbBuscar.Controls.Add(this.txtBuscarText);
            this.gbBuscar.Controls.Add(this.cbBuscarPor);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Location = new System.Drawing.Point(13, 53);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(659, 55);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            // 
            // bttBuscar
            // 
            this.bttBuscar.BackColor = System.Drawing.Color.Silver;
            this.bttBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBuscar.ForeColor = System.Drawing.Color.Red;
            this.bttBuscar.Location = new System.Drawing.Point(551, 20);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 3;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarText
            // 
            this.txtBuscarText.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarText.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBuscarText.Location = new System.Drawing.Point(281, 20);
            this.txtBuscarText.Name = "txtBuscarText";
            this.txtBuscarText.Size = new System.Drawing.Size(263, 23);
            this.txtBuscarText.TabIndex = 2;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.BackColor = System.Drawing.Color.Silver;
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBuscarPor.ForeColor = System.Drawing.Color.DarkRed;
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Cargo",
            "Correo",
            "Nombre",
            "Nombre de Usuario",
            "Rol",
            "Sucursal",
            "Todos"});
            this.cbBuscarPor.Location = new System.Drawing.Point(107, 20);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(168, 21);
            this.cbBuscarPor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.bttCambiar);
            this.groupBox1.Controls.Add(this.bttModificarUsuario);
            this.groupBox1.Controls.Add(this.bttNuevoUsuario);
            this.groupBox1.Controls.Add(this.dgUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 475);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // bttCambiar
            // 
            this.bttCambiar.BackColor = System.Drawing.Color.Silver;
            this.bttCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCambiar.ForeColor = System.Drawing.Color.Red;
            this.bttCambiar.Location = new System.Drawing.Point(687, 437);
            this.bttCambiar.Name = "bttCambiar";
            this.bttCambiar.Size = new System.Drawing.Size(166, 32);
            this.bttCambiar.TabIndex = 14;
            this.bttCambiar.Text = "Cambiar Contraseña";
            this.bttCambiar.UseVisualStyleBackColor = false;
            // 
            // bttModificarUsuario
            // 
            this.bttModificarUsuario.BackColor = System.Drawing.Color.Silver;
            this.bttModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttModificarUsuario.ForeColor = System.Drawing.Color.Red;
            this.bttModificarUsuario.Location = new System.Drawing.Point(536, 437);
            this.bttModificarUsuario.Name = "bttModificarUsuario";
            this.bttModificarUsuario.Size = new System.Drawing.Size(145, 32);
            this.bttModificarUsuario.TabIndex = 5;
            this.bttModificarUsuario.Text = "Modificar Usuario";
            this.bttModificarUsuario.UseVisualStyleBackColor = false;
            // 
            // bttNuevoUsuario
            // 
            this.bttNuevoUsuario.BackColor = System.Drawing.Color.Silver;
            this.bttNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNuevoUsuario.ForeColor = System.Drawing.Color.Red;
            this.bttNuevoUsuario.Location = new System.Drawing.Point(393, 437);
            this.bttNuevoUsuario.Name = "bttNuevoUsuario";
            this.bttNuevoUsuario.Size = new System.Drawing.Size(137, 32);
            this.bttNuevoUsuario.TabIndex = 4;
            this.bttNuevoUsuario.Text = "Nuevo Usuario";
            this.bttNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToResizeColumns = false;
            this.dgUsuarios.AllowUserToResizeRows = false;
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUsuarios.Location = new System.Drawing.Point(7, 23);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(846, 408);
            this.dgUsuarios.TabIndex = 0;
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
            this.label3.TabIndex = 13;
            this.label3.Text = "etFlics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 53);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormUsersMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.bttVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUsersMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsersMaster_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttVolver;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.TextBox txtBuscarText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttCambiar;
        private System.Windows.Forms.Button bttModificarUsuario;
        private System.Windows.Forms.Button bttNuevoUsuario;
        private System.Windows.Forms.DataGridView dgUsuarios;
    }
}