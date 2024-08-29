namespace Fase1_spa
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
            simulatorName = new Label();
            labelAuthor = new Label();
            labelCurso = new Label();
            txtPassword = new TextBox();
            labelPassword = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // simulatorName
            // 
            simulatorName.AutoSize = true;
            simulatorName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            simulatorName.Location = new Point(264, 78);
            simulatorName.Name = "simulatorName";
            simulatorName.Size = new Size(227, 30);
            simulatorName.TabIndex = 0;
            simulatorName.Text = "Simulador SPA ROBLES";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(304, 26);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(159, 15);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "José Ricardo Castro González";
            // 
            // labelCurso
            // 
            labelCurso.AutoSize = true;
            labelCurso.Location = new Point(287, 41);
            labelCurso.Name = "labelCurso";
            labelCurso.Size = new Size(204, 15);
            labelCurso.TabIndex = 2;
            labelCurso.Text = "Curso Estructura de datos 301305_109";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(304, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(310, 183);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Contraseña:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(310, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(155, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Ingresar";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(labelCurso);
            Controls.Add(labelAuthor);
            Controls.Add(simulatorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label simulatorName;
        private Label labelAuthor;
        private Label labelCurso;
        private TextBox txtPassword;
        private Label labelPassword;
        private Button btnCalcular;
    }
}