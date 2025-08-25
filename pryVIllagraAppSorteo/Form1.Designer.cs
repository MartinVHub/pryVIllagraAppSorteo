namespace pryVIllagraAppSorteo
{
    partial class Form1
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
            textBox1 = new TextBox();
            lblNombreDelSorteo = new Label();
            button1 = new Button();
            lblFechaDelSorteo = new Label();
            lblCantidadParticipantes = new Label();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(209, 258);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 2;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            textBox3.Location = new Point(221, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 23);
            textBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(221, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(602, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(lblCantidadParticipantes);
            Controls.Add(lblFechaDelSorteo);
            Controls.Add(button1);
            Controls.Add(lblNombreDelSorteo);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblNombreDelSorteo;
        private Button button1;
        private Label lblFechaDelSorteo;
        private Label lblCantidadParticipantes;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
    }
}
