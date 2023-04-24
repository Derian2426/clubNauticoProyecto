using clubNauticoProyecto.Controller;
using clubNauticoProyecto.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class Form_Vista_Ciudad : Formulario_base
    {
        CiudadController ciudadController;
        Ciudad ciudadAcciones;
        public Form_Vista_Ciudad()
        {
            InitializeComponent();
        }

        public override DataTable listarRegistro()
        {
            ciudadController = new CiudadController();
            return ciudadController.ListaCiudad;
        }
        public override void carga_registro(DataGridView datos)
        {
            base.carga_registro(datos);
            datos.Columns[0].Visible = false;
            datos.Columns[1].Visible = false;
            obtener_pais_seleccion();
        }
        public override DataTable buscarRegistro()
        {
            return ciudadController.busquedaCiudad(new Ciudad(txtBuscador.Text.ToString()));
        }
        private void obtener_pais_seleccion()
        {
            ciudadController = new CiudadController();
            ciudadController.llenarListaPais(cmb_pais, "PAIS", "IDPAIS", "registroPais");
            if (cmb_pais.Items.Count > 0)
            {
                cmb_pais.SelectedIndex = 0;
                ciudadController.Ciudad.Pais.NamePais = cmb_pais.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(cmb_pais.SelectedValue.ToString()); // Obtener el valor del ValueMember
            }
        }

        public override void datosCombo(DataGridViewRow regristro)
        {
            ciudadController = new CiudadController();
            txt_datos_modificar.Text = regristro.Cells[3].Value?.ToString().Trim();
            ciudadController.Ciudad.IdCiudad = Convert.ToInt32(regristro.Cells[0].Value?.ToString().Trim());
            ciudadController.Ciudad.Name_ciudad = regristro.Cells[3].Value?.ToString().Trim();
            ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(regristro.Cells[1].Value?.ToString().Trim());
            ciudadController.llenarListaPaisID(cmb_edit_pais, "PAIS", "IDPAIS", "pais_ciudad");
        }
        private void selecion_datos_combo_pais(ComboBox lista_pais)
        {
            var seleccionado = lista_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                ciudadController.Ciudad.Pais.NamePais = seleccionado[lista_pais.DisplayMember].ToString();
                ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[lista_pais.ValueMember].ToString());
            }
        }

        private void seleccionar_pais_ciudad(object sender, EventArgs e)
        {
            ciudadController = new CiudadController();
            selecion_datos_combo_pais(cmb_pais);
        }
        public override void modificarRegistro()
        {
            ciudadController.Ciudad.Name_ciudad = txt_datos_modificar.Text.ToString().Trim();
            ciudadAcciones = ciudadController.updateCiudad();
            if (ciudadAcciones.IdCiudad != -1)
            {
                MessageBox.Show(ciudadAcciones.Name_ciudad.Trim() + " se modifico correctamente.");
                txt_datos_modificar.Text = "";
            }
            else
            {
                MessageBox.Show(ciudadAcciones.Name_ciudad.Trim() + " no se modifico, por que el registro ya existe.");
            }
        }
        public override void guardarRegistro()
        {
            ciudadController.Ciudad.Name_ciudad = txt_datos_registro.Text.Trim();
            ciudadAcciones = ciudadController.insertCiudad();
            if (ciudadAcciones.IdCiudad == -1)
                MessageBox.Show("La ciudad " + ciudadAcciones.Name_ciudad.Trim() + " ya se encuentra registrado");
            else
            {
                MessageBox.Show("La ciudad " + ciudadAcciones.Name_ciudad.Trim() + " se registro con exito.");
                txt_datos_registro.Text = "";
            }
        }
        public override void eliminarRegistro()
        {
            ciudadController.Ciudad.Name_ciudad = txt_datos_modificar.Text.ToString().Trim();
            ciudadAcciones = ciudadController.deleteCiudad();
            if (ciudadAcciones.IdCiudad != -1)
            {
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " se elimino correctamente.");
                txt_datos_modificar.Text = "";
            }
            else
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " no se elimino.");
        }
        public override void cambio_visibilidad_acciones(bool visibilidad)
        {
            base.cambio_visibilidad_acciones(visibilidad);
            obtener_pais_seleccion();
        }

        private void cargar_lista_paises(object sender, MouseEventArgs e)
        {
            ciudadController.llenarListaPais(cmb_edit_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void buscar_por_letra(object sender, KeyPressEventArgs e)
        {
            buscar_cmb_pais(e, cmb_edit_pais);
        }

        private void buscar_cob_pais(object sender, KeyPressEventArgs e)
        {
            buscar_cmb_pais(e,cmb_pais);
        }
        private void buscar_cmb_pais(KeyPressEventArgs e, ComboBox lista_pais)
        {
            int charCode = (int)e.KeyChar;
            if (charCode == 8)
                ciudadController.Ciudad.Pais.NamePais ="";
            else
                ciudadController.Ciudad.Pais.NamePais = e.KeyChar.ToString();
            ciudadController.llenarListaPais(lista_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void edit_selection_pais(object sender, EventArgs e)
        {
            selecion_datos_combo_pais(cmb_edit_pais);
        }
        public override void imprimirReporte()
        {
            Form_Vista_Reporte reprte = new Form_Vista_Reporte();
            reprte.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listarRegistro()));
            reprte.reportViewer1.LocalReport.ReportEmbeddedResource = "clubNauticoProyecto.Reporte.Reporte_Ciudad.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("HoraActual", DateTime.Now.ToString());
            reprte.reportViewer1.LocalReport.SetParameters(parametros);
            reprte.reportViewer1.RefreshReport();
            reprte.ShowDialog();
            reprte.Dispose();
        }
    }
}
