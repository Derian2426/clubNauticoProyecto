using clubNauticoProyecto.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubNauticoProyecto.Model;
using Microsoft.Reporting.WinForms;

namespace clubNauticoProyecto.Vistas
{
    public partial class Form_Vista_Pais : Formulario_base
    {
        PaisController paisController;
        Pais paisAcciones;
        public Form_Vista_Pais()
        {
            InitializeComponent();
        }

        public override void guardarRegistro()
        {
            paisController.Pais.NamePais = txt_datos_registro.Text.Trim();
            paisAcciones = paisController.insertPais();
            if (paisAcciones.IdPais == -1)
                MessageBox.Show("El pais " + paisAcciones.NamePais.Trim() + " ya se encuentra registrado");
            else
            {
                MessageBox.Show("El pais " + paisAcciones.NamePais.Trim() + " se registro con exito.");
                txt_datos_registro.Text = "";
            }
        }
        public override DataTable listarRegistro()
        {
            paisController = new PaisController();
            return paisController.ListaPais;
        }

        public override DataTable buscarRegistro()
        {
            return paisController.busquedaPais(new Pais(txtBuscador.Text.ToString()));
        }
        public override void datosCombo(DataGridViewRow regristro)
        {
            txt_datos_modificar.Text = regristro.Cells[1].Value?.ToString().Trim();
            paisController.Pais.IdPais = Convert.ToInt32(regristro.Cells[0].Value?.ToString().Trim());
            paisController.Pais.NamePais = regristro.Cells[1].Value?.ToString().Trim();
        }
        public override void modificarRegistro()
        {
            paisController.Pais.NamePais = txt_datos_modificar.Text.ToString().Trim();
            paisAcciones = paisController.updatePais();
            if (paisAcciones.IdPais != -1)
            {
                MessageBox.Show(paisAcciones.NamePais.Trim() + " se modifico correctamente.");
                txt_datos_modificar.Text = "";
            }
            else
            {
                MessageBox.Show(txt_datos_modificar.Text.ToString().Trim() + " no se modifico, por que el registro ya existe.");
            }
        }
        public override void eliminarRegistro()
        {
            paisController.Pais.NamePais = txt_datos_modificar.Text.ToString().Trim();
            paisAcciones = paisController.deletePais();
            if (paisAcciones.IdPais != -1)
            {
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " se elimino correctamente.");
                txt_datos_modificar.Text = "";
            }
            else
                MessageBox.Show(txt_datos_modificar.Text.ToString() + " no se elimino.");
        }
        public override void carga_registro(DataGridView datos)
        {
            base.carga_registro(datos);
            datos.Columns[0].Visible = false;
        }
        public override void imprimirReporte()
        {
            Form_Vista_Reporte reprte = new Form_Vista_Reporte();
            reprte.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listarRegistro()));
            reprte.reportViewer1.LocalReport.ReportEmbeddedResource = "clubNauticoProyecto.Reporte.Report_pais.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("HoraActual", DateTime.Now.ToString());
            reprte.reportViewer1.LocalReport.SetParameters(parametros);
            reprte.reportViewer1.RefreshReport();
            reprte.ShowDialog();
            reprte.Dispose();
        }
    }
}
