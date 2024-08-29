namespace Fase1_spa
{
    partial class MainForm
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
            label1 = new Label();
            txtNombre = new TextBox();
            cedula = new Label();
            txtCedula = new TextBox();
            label2 = new Label();
            cmbServicio = new ComboBox();
            label3 = new Label();
            cmbEstrato = new ComboBox();
            label6 = new Label();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.AcceptsReturn = true;
            txtNombre.Location = new Point(541, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 1;
            // 
            // cedula
            // 
            cedula.AutoSize = true;
            cedula.Location = new Point(55, 66);
            cedula.Name = "cedula";
            cedula.Size = new Size(44, 15);
            cedula.TabIndex = 2;
            cedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(113, 67);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(187, 23);
            txtCedula.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 127);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Servicio";
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Corte y cepillado", "Corte, cepillado y uñas", "Uñas en acrílico y cejas", "Uñas en acrílico, maquillaje y cejas" });
            cmbServicio.Location = new Point(123, 124);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(186, 23);
            cmbServicio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 131);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Estrato";
            // 
            // cmbEstrato
            // 
            cmbEstrato.FormattingEnabled = true;
            cmbEstrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbEstrato.Location = new Point(545, 127);
            cmbEstrato.Name = "cmbEstrato";
            cmbEstrato.Size = new Size(160, 23);
            cmbEstrato.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 232);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor a Pagar";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(360, 377);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(172, 38);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(178, 232);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(cmbEstrato);
            Controls.Add(label3);
            Controls.Add(cmbServicio);
            Controls.Add(label2);
            Controls.Add(txtCedula);
            Controls.Add(cedula);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label cedula;
        private TextBox txtCedula;
        private Label label2;
        private ComboBox cmbServicio;
        private Label label3;
        private ComboBox cmbEstrato;
        private Label label6;
        private Button btnCalcular;
        private Label lblResultado;
    }
}