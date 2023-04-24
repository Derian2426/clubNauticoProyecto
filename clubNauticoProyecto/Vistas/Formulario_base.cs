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
    public partial class Formulario_base : Form
    {
        public Formulario_base()
        {
            InitializeComponent();
        }
        private bool validar_cuadro_texto(TextBox cuador_texto)
        {
            return cuador_texto.Text != "" ? true : false;
        }

        public virtual void guardarRegistro()
        {

        }
        public virtual void modificarRegistro()
        {

        }
        public virtual void eliminarRegistro()
        {

        }
        private bool cerrarFormulario()
        {
            return txt_datos_registro.Text == "" && txt_datos_modificar.Text == "" ? false : true;
        }
        public virtual DataTable listarRegistro()
        {
            return new DataTable();
        }
        public virtual DataTable buscarRegistro()
        {
            return new DataTable();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validar_cuadro_texto(txt_datos_modificar))
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    modificarRegistro();
                    carga_registro(dgv_lista_registro);
                    cambio_visibilidad_acciones(true);
                }               
            }
            else
                MessageBox.Show("Por favor no deje ningun campo sin llenar");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (validar_cuadro_texto(txt_datos_modificar))
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado? Ten en cuenta que esta acción implicará la eliminación en cascada de todos los datos que estén vinculados a dicho registro en la base de datos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    eliminarRegistro();
                    carga_registro(dgv_lista_registro);
                    cambio_visibilidad_acciones(true);
                }
            }
            else
                MessageBox.Show("Por favor no deje ningun campo vacio.");
        }

        public virtual void carga_registro(DataGridView datos)
        {
            datos.DataSource = listarRegistro();
        }

        private void buscar_registro(object sender, EventArgs e)
        {
            dgv_lista_registro.DataSource=buscarRegistro();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validar_cuadro_texto(txt_datos_registro))
            {
                guardarRegistro();
                carga_registro(dgv_lista_registro);
            }
            else
                MessageBox.Show("Por favor no deje ningun campo vacio.");
        }

        private void btn_activar_agregar_Click(object sender, EventArgs e)
        {
            cambio_visibilidad_acciones(true);
        }
        public virtual void cambio_visibilidad_acciones(bool visibilidad)
        {
            grb_Acciones.Visible = !visibilidad;
            grb_registro.Visible = visibilidad;
        }

        private DataGridViewRow accion_edit_update(DataGridViewCellMouseEventArgs e)
        {
            cambio_visibilidad_acciones(false);
            DataGridViewRow filaSeleccionada= new DataGridViewRow();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_lista_registro.Rows.Count)
            {
                filaSeleccionada = dgv_lista_registro.Rows[e.RowIndex];
                if (filaSeleccionada != null)
                {
                    datosCombo(filaSeleccionada);
                }
            }
            return filaSeleccionada;
            
        }
        public virtual void datosCombo(DataGridViewRow regristro)
        {
        }

        private void extraer_datos_rows(object sender, DataGridViewCellMouseEventArgs e)
        {
            accion_edit_update(e);
        }

        private void txtBuscador_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "Buscar...")
            {
                txtBox.Clear();
                txtBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void Formulario_base_Load(object sender, EventArgs e)
        {
            carga_registro(dgv_lista_registro);
        }

        private void cerrarFormulario(object sender, FormClosingEventArgs e)
        {
            if (cerrarFormulario())
            {
                DialogResult result = MessageBox.Show("¿Desea cerrar el formulario sin guardar los datos?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            imprimirReporte();
        }
        public virtual void imprimirReporte()
        {

        }
    }
}
