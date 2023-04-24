using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clubNauticoProyecto.AccesoDatos;
using clubNauticoProyecto.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace clubNauticoProyecto.Controller
{
    class CiudadController
    {
        private Conexion conexion;
        private DataTable listaPais;
        private DataTable listaCiudad;
        private Ciudad ciudad;

        public CiudadController()
        {
            conexion = new Conexion();
            ciudad = new Ciudad();
            ciudad.Name_ciudad = " ";
            ciudad.Pais.NamePais = " ";
        }

        public Ciudad Ciudad { get => ciudad; set => ciudad = value; }
        public DataTable ListaCiudad { get {
                conexion.SentenciaSQL = "registroCiudad";
                listaCiudad = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", ciudad.Name_ciudad));
                return listaCiudad;
            } set => listaCiudad = value; }

        public void llenarListaPais(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", ciudad.Pais.NamePais));
            cmbListaPais.DataSource = listaPais;
            cmbListaPais.DisplayMember = listaPais.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaPais.Columns[campovalor].ToString().Trim();
        }
        public void llenarListaPaisID(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@idpais", ciudad.Pais.IdPais));
            cmbListaPais.DataSource = listaPais;
            cmbListaPais.DisplayMember = listaPais.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaPais.Columns[campovalor].ToString().Trim();
        }
        public Ciudad insertCiudad()
        {
            conexion.SentenciaSQL = "registrar_ciudad";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@ciudad", ciudad.Name_ciudad), new SqlParameter("@idpais", ciudad.Pais.IdPais));
            ciudad = new Ciudad();
            return new Ciudad(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
        public Ciudad updateCiudad()
        {
            conexion.SentenciaSQL = "modificar_ciudad";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@ciudad", ciudad.Name_ciudad), new SqlParameter("@idpais", ciudad.Pais.IdPais), new SqlParameter("@idciudad", ciudad.IdCiudad));
            ciudad = new Ciudad();
            return new Ciudad(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
        public Ciudad deleteCiudad()
        {
            conexion.SentenciaSQL = "eliminar_ciudad";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@idciudad", ciudad.IdCiudad));
            ciudad = new Ciudad();
            return new Ciudad(Convert.ToInt32(listaPais.Rows[0][0]));
        }
        public DataTable busquedaCiudad(Ciudad ciudad)
        {
            conexion.SentenciaSQL = "registroCiudad";
            listaCiudad = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", ciudad.Name_ciudad));
            return listaCiudad;
        }
    }
}
