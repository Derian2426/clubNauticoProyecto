using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubNauticoProyecto.Model
{
    class Pais
    {
        private int idPais;
        private string namePais;

        public Pais()
        {
        }

        public Pais(int idPais)
        {
            this.idPais = idPais;
        }

        public Pais(string namePais)
        {
            this.namePais = namePais;
        }

        public Pais(int idPais, string namePais)
        {
            this.idPais = idPais;
            this.namePais = namePais;
        }

        public int IdPais { get => idPais; set => idPais = value; }
        public string NamePais { get => namePais; set => namePais = value; }
    }
}
