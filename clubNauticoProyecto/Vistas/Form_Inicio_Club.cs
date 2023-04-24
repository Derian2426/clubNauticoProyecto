
using clubNauticoProyecto.Vistas;
using System;
using System.Windows.Forms;

namespace clubNauticoProyecto
{
    public partial class Form_Inicio_Club : Form
    {
        public Form_Inicio_Club()
        {
            InitializeComponent();
        }

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            Form_Vista_Pais pais = new Form_Vista_Pais();
            pais.ShowDialog();
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            Form_Vista_Ciudad ciudad = new Form_Vista_Ciudad();
            ciudad.ShowDialog();
        }

        private void btn_Puerto_Click(object sender, EventArgs e)
        {
            Form_Vista_Puerto puerto = new Form_Vista_Puerto();
            puerto.ShowDialog();
        }
    }
}
