namespace pryVIllagraAppSorteo
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNombreSorteo = new TextBox();
            lblNombreDelSorteo = new Label();
            btnRegistrar = new Button();
            lblFechaDelSorteo = new Label();
            lblCantidadParticipantes = new Label();
            txtCantidad = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dtpFechaSorteo = new DateTimePicker();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombreSorteo
            // 
            txtNombreSorteo.Location = new Point(221, 47);
            txtNombreSorteo.Name = "txtNombreSorteo";
            txtNombreSorteo.Size = new Size(146, 23);
            txtNombreSorteo.TabIndex = 0;
            // 
            // lblNombreDelSorteo
            // 
            lblNombreDelSorteo.AutoSize = true;
            lblNombreDelSorteo.BackColor = Color.White;
            lblNombreDelSorteo.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreDelSorteo.ForeColor = Color.Red;
            lblNombreDelSorteo.Location = new Point(45, 46);
            lblNombreDelSorteo.Name = "lblNombreDelSorteo";
            lblNombreDelSorteo.Size = new Size(144, 20);
            lblNombreDelSorteo.TabIndex = 1;
            lblNombreDelSorteo.Text = "NombreDelSorteo";
            lblNombreDelSorteo.Click += lblNombreDelSorteo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(231, 257);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 34);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblFechaDelSorteo
            // 
            lblFechaDelSorteo.AutoSize = true;
            lblFechaDelSorteo.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDelSorteo.ForeColor = Color.Red;
            lblFechaDelSorteo.Location = new Point(45, 109);
            lblFechaDelSorteo.Name = "lblFechaDelSorteo";
            lblFechaDelSorteo.Size = new Size(123, 20);
            lblFechaDelSorteo.TabIndex = 4;
            lblFechaDelSorteo.Text = "FechaDelSorteo";
            // 
            // lblCantidadParticipantes
            // 
            lblCantidadParticipantes.AutoSize = true;
            lblCantidadParticipantes.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadParticipantes.ForeColor = Color.Red;
            lblCantidadParticipantes.Location = new Point(45, 182);
            lblCantidadParticipantes.Name = "lblCantidadParticipantes";
            lblCantidadParticipantes.Size = new Size(170, 20);
            lblCantidadParticipantes.TabIndex = 5;
            lblCantidadParticipantes.Text = "CantidadParticipantes";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(221, 183);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(49, 23);
            txtCantidad.TabIndex = 6;
            // 
            // dtpFechaSorteo
            // 
            dtpFechaSorteo.Location = new Point(221, 109);
            dtpFechaSorteo.Name = "dtpFechaSorteo";
            dtpFechaSorteo.Size = new Size(161, 23);
            dtpFechaSorteo.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(63, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 33);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(410, 394);
            Controls.Add(btnCancelar);
            Controls.Add(dtpFechaSorteo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidadParticipantes);
            Controls.Add(lblFechaDelSorteo);
            Controls.Add(btnRegistrar);
            Controls.Add(lblNombreDelSorteo);
            Controls.Add(txtNombreSorteo);
            Name = "login";
            Text = "Aplicacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreSorteo;
        private Label lblNombreDelSorteo;
        private Button btnRegistrar;
        private Label lblFechaDelSorteo;
        private Label lblCantidadParticipantes;
        private TextBox txtCantidad;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtpFechaSorteo;
        private Button btnCancelar;
    }
}
