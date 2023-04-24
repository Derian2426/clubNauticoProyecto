using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubNauticoProyecto.Model
{
    class Ciudad
    {
        private Pais pais;
        private int idCiudad;
        private string name_ciudad;

        public Ciudad()
        {
            pais = new Pais();
        }

        public Ciudad(int idCiudad)
        {
            this.idCiudad = idCiudad;
        }

        public Ciudad(string name_ciudad)
        {
            this.name_ciudad = name_ciudad;
        }

        public Ciudad(int idCiudad, string name_ciudad)
        {
            this.idCiudad = idCiudad;
            this.name_ciudad = name_ciudad;
        }

        public Ciudad(Pais pais)
        {
            this.pais = pais;
        }

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Name_ciudad { get => name_ciudad; set => name_ciudad = value; }
        internal Pais Pais { get => pais; set => pais = value; }
    }
}
