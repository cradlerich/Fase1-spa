namespace Fase1_spa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "123")
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Contraseña Invalida\nIntente de nuevo");
                txtPassword.Clear();
            }
        }
    }
}