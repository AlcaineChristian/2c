using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {


            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {


            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            double ret = 0;
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
            ret = Calculadora.Operar(n1, n2, operador);
            return ret;
        }
    }
}
