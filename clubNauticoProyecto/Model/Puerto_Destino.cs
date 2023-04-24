using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubNauticoProyecto.Model
{
    class Puerto_Destino
    {
        private int idPuerto;
        private string nombrePuerto;
        private Ciudad ciudad;

        public Puerto_Destino(int idPuerto)
        {
            this.idPuerto = idPuerto;
        }

        public Puerto_Destino()
        {
            ciudad = new Ciudad();
        }

        public Puerto_Destino(int idPuerto, string nombrePuerto)
        {
            this.idPuerto = idPuerto;
            this.nombrePuerto = nombrePuerto;
        }

        public int IdPuerto { get => idPuerto; set => idPuerto = value; }
        public string NombrePuerto { get => nombrePuerto; set => nombrePuerto = value; }
        internal Ciudad Ciudad { get => ciudad; set => ciudad = value; }
    }
}
