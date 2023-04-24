using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubNauticoProyecto.Controller;
using clubNauticoProyecto.Model;
using Microsoft.Reporting.WinForms;

namespace clubNauticoProyecto.Vistas
{
    public partial class Form_Vista_Puerto : Formulario_base
    {
        PuertoController puertoController;
        Puerto_Destino puerto;
        public Form_Vista_Puerto()
        {
            InitializeComponent();
        }

        public override DataTable listarRegistro()
        {
            puertoController = new PuertoController();
            return puertoController.ListaPuerto;
        }
        public override void carga_registro(DataGridView datos)
        {
            base.carga_registro(datos);
            datos.Columns[0].Visible = false;
            datos.Columns[1].Visible = false;
            datos.Columns[2].Visible = false;
            obtener_pais_seleccion();
        }
        private void obtener_pais_seleccion()
        {
            puertoController = new PuertoController();
            puertoController.llenarListaPais(cmb_pais, "PAIS", "IDPAIS", "registroPais");
            if (cmb_pais.Items.Count > 0)
            {
                cmb_pais.SelectedIndex = 0;
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = cmb_pais.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(cmb_pais.SelectedValue.ToString()); // Obtener el valor del ValueMember
                
            }
            puertoController.llenarListaCiudad(cmb_ListaCiudades, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
            if (cmb_ListaCiudades.Items.Count > 0)
            {
                cmb_ListaCiudades.SelectedIndex = 0;
                puertoController.Puerto_Destino.Ciudad.Name_ciudad = cmb_ListaCiudades.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(cmb_ListaCiudades.SelectedValue.ToString()); // Obtener el valor del ValueMember
            }
        }

        private void seleccionar_pais_change_ciudad(object sender, EventArgs e)
        {
            var seleccionado = cmb_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = seleccionado[cmb_pais.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_pais.ValueMember].ToString());
            }
            puertoController.llenarListaCiudad(cmb_ListaCiudades, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
        }
        public override void datosCombo(DataGridViewRow regristro)
        {
            puertoController = new PuertoController();
            txt_datos_modificar.Text = regristro.Cells[5].Value?.ToString().Trim();
            puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(regristro.Cells[0].Value?.ToString());
            puertoController.Puerto_Destino.IdPuerto = Convert.ToInt32(regristro.Cells[2].Value?.ToString());
            puertoController.Puerto_Destino.NombrePuerto = regristro.Cells[5].Value?.ToString().Trim();
            puertoController.Puerto_Destino.Ciudad.Pais.IdPais= Convert.ToInt32(regristro.Cells[1].Value?.ToString());
            puertoController.llenarListaCiudadID(cmb_edit_ciudad, "CIUDAD", "IDCIUDAD", "ciudad_puerto");
            puertoController.llenarListaPaisID(cmb_edit_pais, "PAIS", "IDPAIS", "pais_puerto");
        }

        private void listar_pais(object sender, MouseEventArgs e)
        {
            puertoController.Puerto_Destino.Ciudad.Pais.NamePais = " ";
            puertoController.llenarListaPais(cmb_edit_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void selecction_edit_pais(object sender, EventArgs e)
        {
            var seleccionado = cmb_edit_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = seleccionado[cmb_edit_pais.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_edit_pais.ValueMember].ToString());
            }
            puertoController.llenarListaCiudad(cmb_edit_ciudad, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
            if (cmb_edit_ciudad.Items.Count > 0)
            {
                if (cmb_edit_ciudad.Items.Count > 0)
                {
                    cmb_edit_ciudad.SelectedIndex = 0;
                    puertoController.Puerto_Destino.Ciudad.Name_ciudad = cmb_edit_ciudad.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                    puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(cmb_edit_ciudad.SelectedValue.ToString()); // Obtener el valor del ValueMember
                }
            }
            else
                puertoController.Puerto_Destino.Ciudad.IdCiudad = -1;


        }
        public override void cambio_visibilidad_acciones(bool visibilidad)
        {
            base.cambio_visibilidad_acciones(visibilidad);
            obtener_pais_seleccion();
        }
        private void buscar_cmb_pais(KeyPressEventArgs e, ComboBox lista_pais)
        {
            int charCode = (int)e.KeyChar;
            if (charCode == 8)
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = "";
            else
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = e.KeyChar.ToString();
            puertoController.llenarListaPais(lista_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void buscra_pais(object sender, KeyPressEventArgs e)
        {
            buscar_cmb_pais(e,cmb_pais);
        }

        private void buscar_edit_pais(object sender, KeyPressEventArgs e)
        {
            buscar_cmb_pais(e, cmb_edit_pais);
        }
        public override void guardarRegistro()
        {
            puertoController.Puerto_Destino.NombrePuerto = txt_datos_registro.Text.ToString().Trim();
            puerto = puertoController.insertPuerto();
            if (puerto.IdPuerto == -1)
                MessageBox.Show("El puerto " + puerto.NombrePuerto.Trim() + " ya se encuentra registrado");
            else
            {
                MessageBox.Show("El puerto " + puerto.NombrePuerto.Trim() + " se registro con exito.");
                txt_datos_registro.Text = "";
            }
        }
        public override void eliminarRegistro()
        {
            puertoController.Puerto_Destino.NombrePuerto = txt_datos_modificar.Text.ToString().Trim();
            puerto = puertoController.deletePuerto();
            if (puerto.IdPuerto != -1)
            {
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " se elimino correctamente.");
                txt_datos_modificar.Text = "";
            }
            else
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " no se elimino.");
        }
        public override void modificarRegistro()
        {
            if (puertoController.Puerto_Destino.Ciudad.IdCiudad!=-1)
            {
                puertoController.Puerto_Destino.NombrePuerto = txt_datos_modificar.Text.ToString().Trim();
                puerto = puertoController.updatePuerto();
                if (puerto.IdPuerto != -1)
                {
                    MessageBox.Show(puerto.NombrePuerto.Trim() + " se modifico correctamente.");
                    txt_datos_modificar.Text = "";
                }
                else
                    MessageBox.Show(puerto.NombrePuerto.Trim() + " no se modifico, por que el registro ya existe.");
            }else
                MessageBox.Show("No existen registros de ciudades en el pais, por favor ingrese al modulo ciudades y registre ciudad al pais.");

        }

        private void lista_ciudad_edit(object sender, MouseEventArgs e)
        {
            puertoController.llenarListaCiudad(cmb_edit_ciudad, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
        }

        private void seleccion_edit_ciudad(object sender, EventArgs e)
        {
            var seleccionado = cmb_edit_ciudad.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Name_ciudad = seleccionado[cmb_edit_ciudad.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(seleccionado[cmb_edit_ciudad.ValueMember].ToString());
            }
        }
        public override void imprimirReporte()
        {
            Form_Vista_Reporte reprte = new Form_Vista_Reporte();
            reprte.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listarRegistro()));
            reprte.reportViewer1.LocalReport.ReportEmbeddedResource = "clubNauticoProyecto.Reporte.Reporte_Puerto.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("HoraActual", DateTime.Now.ToString());
            reprte.reportViewer1.LocalReport.SetParameters(parametros);
            reprte.reportViewer1.RefreshReport();
            reprte.ShowDialog();
            reprte.Dispose();
        }
    }
}
