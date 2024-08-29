using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1_spa
{
    public partial class MainForm : Form
    {
        private Controller controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string servicioSeleccionado = cmbServicio.SelectedItem.ToString();
                    int estrato = int.Parse(cmbEstrato.SelectedItem.ToString());

                    var servicio = controller.CrearServicio(servicioSeleccionado, estrato);
                    double valorFinal = servicio.CalcularValorFinal();

                    lblResultado.Text = $"Identificación: {txtCedula.Text}\nNombre: {txtNombre.Text}\n" +
                                    $"Servicio: {servicio.Servicio}\nEstrato: {estrato}\n" +
                                    $"Valor Original: ${servicio.Precio}\nDescuento: {servicio.Descuento * 100}%\n" +
                                    $"Valor a Pagar: ${valorFinal}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }

        }
    }
}
