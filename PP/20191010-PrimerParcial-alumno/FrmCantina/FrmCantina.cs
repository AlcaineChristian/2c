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
using ControlCantina;



namespace FrmCantina
{
    public partial class FrmCantina : Form
    {

        public FrmCantina()
        {
            InitializeComponent();
            this.rbCerveza.Checked = true;
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {

            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.barra1.SetCantina = Cantina.GetEspacios(10);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;
            string marca = txtMarca.Text;
            int capacidad = (int)numCapacidad.Value;
            int contenido = (int)numContenido.Value;
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            if (rbCerveza.Checked)
            {
                botella = new Cerveza(capacidad, contenido, marca, tipo);
            }
            else
            {
                botella = new Agua(capacidad, contenido, marca);
            }


            barra1.AgregarBotella(botella);

        }

        private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}

