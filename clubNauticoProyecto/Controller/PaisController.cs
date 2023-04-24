using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clubNauticoProyecto.AccesoDatos;
using clubNauticoProyecto.Model;
using System.Data.SqlClient;


namespace clubNauticoProyecto.Controller
{
    class PaisController
    {
        private Conexion conexion;
        private DataTable listaPais;
        private Pais pais;

        public PaisController()
        {
            conexion = new Conexion();
            pais = new Pais();
        }

        public DataTable ListaPais { 
            get {
                conexion.SentenciaSQL = "registroPais";
                listaPais= conexion.ejecutarSentencia(new SqlParameter("@Busqueda", " "));
                return listaPais;

            } set => listaPais = value; 
        }
        public Pais Pais { get => pais; set => pais = value; }

        public Pais insertPais()
        {
            conexion.SentenciaSQL = "registrar_pais";
            listaPais=conexion.ejecutarSentencia(new SqlParameter("@pais",pais.NamePais));
            pais = new Pais();
            return new Pais(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
        public DataTable busquedaPais(Pais pais)
        {
            conexion.SentenciaSQL = "registroPais";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@Busqueda", pais.NamePais));
            return listaPais;
        }
        public Pais deletePais()
        {
            conexion.SentenciaSQL = "eliminar_pais";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@pais", pais.NamePais), new SqlParameter("@idpais", pais.IdPais));
            pais = new Pais();
            return new Pais(Convert.ToInt32(listaPais.Rows[0][0]));
        }
        public Pais updatePais()
        {
            conexion.SentenciaSQL = "modificar_pais";
            listaPais = conexion.ejecutarSentencia(new SqlParameter("@pais", pais.NamePais), new SqlParameter("@idpais", pais.IdPais));
            pais = new Pais();
            return new Pais(Convert.ToInt32(listaPais.Rows[0][0]), listaPais.Rows[0][1].ToString());
        }
    }
}
