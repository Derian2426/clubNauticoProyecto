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
    class PuertoController
    {
        private Conexion conexion;
        private DataTable listaPais;
        private DataTable listaCiudad;
        private DataTable listaPuerto;
        private Puerto_Destino puerto_Destino;

        public PuertoController()
        {
            conexion = new Conexion();
            puerto_Destino = new Puerto_Destino();
            puerto_Destino.Ciudad.Name_ciudad = " ";
            puerto_Destino.Ciudad.Pais.NamePais = " ";
            puerto_Destino.NombrePuerto = "";
        }

        public DataTable ListaPais { get => listaPais; set => listaPais = value; }
        public DataTable ListaCiudad { get => listaCiudad; set => listaCiudad = value; }
        public DataTable ListaPuerto {
            get
            {
                conexion.SentenciaSQL = "registro_puerto";
                listaPuerto = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", puerto_Destino.NombrePuerto));
                return listaPuerto;
            }
            set => listaPuerto = value; }
        internal Puerto_Destino Puerto_Destino { get => puerto_Destino; set => puerto_Destino = value; }

        public void llenarListaPais(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", puerto_Destino.Ciudad.Pais.NamePais));
            cmbListaPais.DataSource = listaPais;
            cmbListaPais.DisplayMember = listaPais.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaPais.Columns[campovalor].ToString().Trim();
        }
        public void llenarListaCiudad(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaCiudad = conexion.ejecutarSentencia(new SqlParameter("@idpais", puerto_Destino.Ciudad.Pais.IdPais));
            cmbListaPais.DataSource = listaCiudad;
            cmbListaPais.DisplayMember = listaCiudad.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaCiudad.Columns[campovalor].ToString().Trim();
        }
        public Puerto_Destino insertPuerto()
        {
            conexion.SentenciaSQL = "regitrar_puerto";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@idciudad", puerto_Destino.Ciudad.IdCiudad), new SqlParameter("@puerto", puerto_Destino.NombrePuerto));
            puerto_Destino = new Puerto_Destino();
            return new Puerto_Destino(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
        public Puerto_Destino updatePuerto()
        {
            conexion.SentenciaSQL = "editar_puerto";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@idpuerto", puerto_Destino.IdPuerto), new SqlParameter("@puerto", puerto_Destino.NombrePuerto), new SqlParameter("@idciudad", puerto_Destino.Ciudad.IdCiudad));
            puerto_Destino = new Puerto_Destino();
            return new Puerto_Destino(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
        public Puerto_Destino deletePuerto()
        {
            conexion.SentenciaSQL = "eliminar_puerto";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@idpuerto", puerto_Destino.IdPuerto));
            puerto_Destino = new Puerto_Destino();
            return new Puerto_Destino(Convert.ToInt32(listaPais.Rows[0][0]));
        }
        public void llenarListaCiudadID(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaCiudad = conexion.ejecutarSentencia(new SqlParameter("@id_ciudad", puerto_Destino.Ciudad.IdCiudad));
            cmbListaPais.DataSource = listaCiudad;
            cmbListaPais.DisplayMember = listaCiudad.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaCiudad.Columns[campovalor].ToString().Trim();
        }
        public void llenarListaPaisID(ComboBox cmbListaPais, string campodisplay, string campovalor, string nameProcedure)
        {
            conexion.SentenciaSQL = nameProcedure;
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@id_ciudad", puerto_Destino.Ciudad.IdCiudad));
            cmbListaPais.DataSource = listaPais;
            cmbListaPais.DisplayMember = listaPais.Columns[campodisplay].ToString().Trim();
            cmbListaPais.ValueMember = listaPais.Columns[campovalor].ToString().Trim();
        }
    }
}
