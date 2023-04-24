using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubNauticoProyecto.Vistas
{
    public partial class Form_Vista_Reporte : Form
    {
        public Form_Vista_Reporte()
        {
            InitializeComponent();
        }

        private void Form_Vista_Reporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
